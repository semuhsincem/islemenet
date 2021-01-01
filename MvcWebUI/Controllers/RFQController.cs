using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using BusinessLayer.Abstract.Middle;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MvcWebUI.IdentityCore;
using ViewModels.Datatable;
using ViewModels.Login;
using ViewModels.RFQ;

namespace MvcWebUI.Controllers
{
    public class RFQController : Controller
    {
        private IAdvertisementService _rfqService;
        private UserManager<AppUser> _userManager { get; set; }
        private RoleManager<AppRole> _roleManager { get; set; }
        private SignInManager<AppUser> _signInManager { get; set; }
        private IUserCertificateService _userCertificateService { get; set; }
        private IUserIndustryService _userIndustryService { get; set; }
        private IUserTechnologyService _userTechnologyService { get; set; }
        private IUserMaterialService _userMaterialService { get; set; }
        public IRFQCountryService _rFQCountryService { get; set; }
        private readonly IConstantService _constantService;
        public RFQController(UserManager<AppUser> userManager,
            RoleManager<AppRole> roleManager,
            SignInManager<AppUser> signInManager,
            IConstantService constantService,
            IUserCertificateService userCertificateService,
            IUserIndustryService userIndustryService,
            IUserTechnologyService userTechnologyService,
            IUserMaterialService userMaterialService,
            IAdvertisementService rfqService,
            IRFQCountryService rFQCountryService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _constantService = constantService;
            _userCertificateService = userCertificateService;
            _userIndustryService = userIndustryService;
            _userTechnologyService = userTechnologyService;
            _userMaterialService = userMaterialService;
            _rfqService = rfqService;
            _rFQCountryService = rFQCountryService;
        }

        public IActionResult Index()
        {
            ViewData["RFQ"] = "menu-item-active";
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {

            ViewData["CreateRFQ"] = "menu-item-active";
            var model = FillModelSelectListItemsForCreateRFQViewModel(new CreateRFQViewModel());
            return View(model);
        }
        [HttpPost]
        public IActionResult Create(CreateRFQViewModel model)
        {
            if (ModelState.IsValid)
            {
                var rfq = _rfqService.AddAdvertisment(new Advertisement()
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
                    Quantity = model.Quantity,
                    RFQDeadline = model.RFQDeadline
                });
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
            return View();
        }

        [HttpPost]
        public IActionResult GetRFQList(DataTableAjaxPostModel model)
        {

            //Db Query -> Start
            var advertisements = _rfqService.GetAdvertisements();
            //Db Queryy -> End

            //int recordsFiltered = advertisements.Count();
            int recordsTotal = advertisements.Count();

            if (model.columns[0].search.value != null)
            {
                string exp = model.columns[0].search.value;
                //advertisements = advertisements.Where(x =>
                //x.Content.ToLower().Contains(exp.ToLower()) ||
                //x.Title.ToLower().Contains(exp.ToLower()) ||
                //x.Cityname.ToLower().Contains(exp.ToLower())).ToList();
            }
            if (model.columns[1].search.value != null && model.columns[1].search.value != "Hiçbiri seçilmedi")
            {
                //foreach (var item in model.columns[1].search.value.Split(","))
                //{
                //    City city = _cityService.GetList(x => x.Name.ToLower() == item.Trim().ToLower()).FirstOrDefault();
                //    if (city != null)
                //    {
                //        expCities.Add(city.Id);

                //    }
                //}
                //advertisementsViewModel = advertisementsViewModel.Where(x => expCities.Contains(x.CityId)).OrderByDescending(x => x.Cityname).ToList();
            }
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
                model.Technogies.Add(new SelectListItem() { Text = item.TechnologyName, Value = item.Id.ToString() });
            foreach (var item in certifications)
                model.Certifications.Add(new SelectListItem() { Text = item.CertificateName, Value = item.Id.ToString() });

            return model;
        }
        [HttpPost]
        public IActionResult FileUpload(IFormFile file)
        {
            return View();
        }


    }
}