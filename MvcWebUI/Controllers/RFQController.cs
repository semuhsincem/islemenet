using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using BusinessLayer.Abstract.Middle;
using BusinessLayer.Abstract.Middle.RfqMiddle;
using Entities.Abstract.MiddleTables.RFQMiddles;
using Entities.Concrete;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MvcWebUI.IdentityCore;
using ViewModels.Datatable;
using ViewModels.RFQ;

namespace MvcWebUI.Controllers
{
    public class RFQController : Controller
    {
        private IRFQService _rfqService;
        private UserManager<AppUser> _userManager { get; set; }
        private RoleManager<AppRole> _roleManager { get; set; }
        private SignInManager<AppUser> _signInManager { get; set; }
        private readonly IWebHostEnvironment _environment;
        private IRfqCertificationService _rfqCertificationService { get; set; }
        private IRfqTechnologyService _rfqTechnologyService { get; set; }
        private IRfqMaterialService _rfqMaterialService { get; set; }
        public IRFQCountryService _rFQCountryService { get; set; }
        public IRfqFileService _rfqFileService { get; set; }
        private readonly IConstantService _constantService;
        public RFQController(UserManager<AppUser> userManager,
            RoleManager<AppRole> roleManager,
            SignInManager<AppUser> signInManager,
            IWebHostEnvironment environment,
            IConstantService constantService,
            IRfqCertificationService rfqCertificationService,
            IRfqTechnologyService rfqTechnologyService,
            IRfqMaterialService rfqMaterialService,
            IRFQService rfqService,
            IRFQCountryService rFQCountryService,
            IRfqFileService rfqFileService
            )
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _environment = environment;
            _constantService = constantService;
            _rfqCertificationService = rfqCertificationService;
            _rfqTechnologyService = rfqTechnologyService;
            _rfqMaterialService = rfqMaterialService;
            _rfqService = rfqService;
            _rFQCountryService = rFQCountryService;
            _rfqFileService = rfqFileService;
        }

        public IActionResult Index()
        {
            ViewData["RFQ"] = "menu-item-active";
            return View();
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([FromForm] CreateRFQViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.GetUserAsync(User);
                var rfq = _rfqService.AddAdvertisment(new RFQ()
                {
                    Title = model.Title,
                    BasicInformation = model.BasicInformation,
                    CustomRFQId = model.CustomRFQId,
                    OfferCurrency = model.OfferCurrency,
                    DelivaryDate = model.DeliveryDate,
                    Width = model.Width,
                    Height = model.Height,
                    Diameter = model.Diameter,
                    Length = model.Length,
                    MinTol = model.MinTol,
                    Need = model.Need,
                    PublicationSettingsType = model.PublicationSettingsId,
                    Quantity = model.Quantity.HasValue ? model.Quantity.Value : 1,
                    RFQDeadline = model.RFQDeadline,
                    UserId = user.Id
                });
                #region Dosyaları Ekle
                List<string> filePaths = new List<string>();
                foreach (var item in model.Files)
                {
                    var path = await UploadFile(item);
                    filePaths.Add(path);
                }
                _rfqFileService.AddFileToRFQ(filePaths, rfq.Id, Enums.RFQHelpers.ECreateRfqFileType.Normal);
                #endregion Dosya Ekle
                #region Teknolojilerini Ekle
                foreach (var item in model.SelectedTechnologies)
                    _rfqTechnologyService.Add(new RfqTechnology() { RFQId = rfq.Id, TechnologyId = Convert.ToInt32(item) });

                #endregion
                #region Materyalleri Ekle
                foreach (var item in model.SelectedMaterials)
                    _rfqMaterialService.Add(new RfqMaterial() { RFQId = rfq.Id, MaterialId = Convert.ToInt32(item) });
                #endregion
                #region Sertifika Ekle
                foreach (var item in model.SelectedCertifications)
                    _rfqCertificationService.Add(new RfqCertification() { RFQId = rfq.Id, CertificationId = Convert.ToInt32(item) });
                #endregion
                if (model.PublicationSettingsId == 2)
                {
                    List<int> selectedList = new List<int>();
                    model.SelectedCountries.ToList().ForEach(x =>
                    {
                        selectedList.Add(Convert.ToInt32(x));
                    });

                    _rFQCountryService.AddCountriesToRFQ(selectedList, rfq.Id);
                }
            }
            return Json(new { success = true });
        }

        [HttpPost]
        public IActionResult GetRFQList([FromForm]SearchRfqViewModel model)
        {

            var res = _rfqService.GetRfqWithIncludes();
            return Json("");
        }

        public CreateRFQViewModel FillModelSelectListItemsForCreateRFQViewModel(CreateRFQViewModel model)
        {
            var companySizes = _constantService.GetCompanySizes();
            var countries = _constantService.GetCountries();
            var industries = _constantService.GetIndustries();
            var materials = _constantService.GetMaterials();
            var technologies = _constantService.GetTechnologies();
            var certifications = _constantService.GetCertifications();

            foreach (var item in companySizes)
                model.CompanySizes.Add(new SelectListItem() { Text = item.CountrySize, Value = item.Id.ToString() });
            foreach (var item in countries)
                model.Countrys.Add(new SelectListItem() { Text = item.COUNTRY_NAME, Value = item.Id.ToString() });
            foreach (var item in industries)
                model.Industries.Add(new SelectListItem() { Text = item.IndustryName, Value = item.Id.ToString() });
            foreach (var item in materials)
                model.Materials.Add(new SelectListItem() { Text = item.MaterialName, Value = item.Id.ToString() });
            foreach (var item in technologies)
                model.Technologies.Add(new SelectListItem() { Text = item.TechnologyName, Value = item.Id.ToString() });
            foreach (var item in certifications)
                model.Certifications.Add(new SelectListItem() { Text = item.CertificateName, Value = item.Id.ToString() });

            return model;
        }
        [HttpPost]
        public IActionResult FileUpload(IFormFile file)
        {
            return View();
        }
        public async Task<string> UploadFile(IFormFile file)
        {
            try
            {
                string folderRoot = Path.Combine(_environment.ContentRootPath, "Uploads");
                string filePath = Guid.NewGuid() + Path.GetExtension(file.FileName);
                filePath = Path.Combine(folderRoot, filePath);
                if (file.Length > 0)
                {

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                }
                return filePath;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }




    }
}