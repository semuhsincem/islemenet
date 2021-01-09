using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using BusinessLayer.Abstract.Middle;
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
        private readonly IHostingEnvironment _environment;
        private IUserCertificateService _userCertificateService { get; set; }
        private IUserIndustryService _userIndustryService { get; set; }
        private IUserTechnologyService _userTechnologyService { get; set; }
        private IUserMaterialService _userMaterialService { get; set; }
        public IRFQCountryService _rFQCountryService { get; set; }
        public IRfqFileService _rfqFileService { get; set; }
        private readonly IConstantService _constantService;
        public RFQController(UserManager<AppUser> userManager,
            RoleManager<AppRole> roleManager,
            SignInManager<AppUser> signInManager,
            IHostingEnvironment environment,
            IConstantService constantService,
            IUserCertificateService userCertificateService,
            IUserIndustryService userIndustryService,
            IUserTechnologyService userTechnologyService,
            IUserMaterialService userMaterialService,
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
            _userCertificateService = userCertificateService;
            _userIndustryService = userIndustryService;
            _userTechnologyService = userTechnologyService;
            _userMaterialService = userMaterialService;
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
                    RFQDeadline = model.RFQDeadline
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
                #region İlanın Teknolojilerini Ekle
                

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
        public IActionResult GetRFQList(DataTableAjaxPostModel model)
        {

            //Db Query -> Start
            var advertisements = _rfqService.GetAdvertisements();
            //Db Queryy -> End

            int recordsTotal = advertisements.Count();

            int recordsFiltered = advertisements.Count();
            var data = advertisements.Skip(model.start).Take(model.length).ToList();
            return Json(new
            {
                draw = model.draw,
                recordsFiltered = recordsFiltered,
                recordsTotal = recordsTotal,
                data = data
            });
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
                if (file.Length > 0)
                {
                    string folderRoot = Path.Combine(_environment.ContentRootPath, "Uploads");
                    string filePath = Guid.NewGuid() + Path.GetExtension(file.FileName);
                    filePath = Path.Combine(folderRoot, filePath);
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                }
                return file.FileName;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }




    }
}