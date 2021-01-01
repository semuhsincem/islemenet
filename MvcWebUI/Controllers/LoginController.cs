using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using BusinessLayer.Abstract.Middle;
using BusinessLayer.Concrete;
using Entities.Abstract.MiddleTables;
using Helper;
using Helper.Constants;
using Helper.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MvcWebUI.IdentityCore;
using MvcWebUI.Models;
using ViewModels.Login;

namespace MvcWebUI.Controllers
{
    public class LoginController : Controller
    {
        private UserManager<AppUser> _userManager { get; set; }
        private RoleManager<AppRole> _roleManager { get; set; }
        private SignInManager<AppUser> _signInManager { get; set; }
        private IUserCertificateService _userCertificateService { get; set; }
        private IUserIndustryService _userIndustryService { get; set; }
        private IUserTechnologyService _userTechnologyService { get; set; }
        private IUserMaterialService _userMaterialService { get; set; }
        private readonly IConstantService _constantService;
        public LoginController(UserManager<AppUser> userManager,
            RoleManager<AppRole> roleManager,
            SignInManager<AppUser> signInManager,
            IConstantService constantService,
            IUserCertificateService userCertificateService,
            IUserIndustryService userIndustryService,
            IUserTechnologyService userTechnologyService,
            IUserMaterialService userMaterialService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _constantService = constantService;
            _userCertificateService = userCertificateService;
            _userIndustryService = userIndustryService;
            _userTechnologyService = userTechnologyService;
            _userMaterialService = userMaterialService;
        }
        [HttpGet]
        public IActionResult Register()
        {
            var model = FillModelSelectListItemsForRegisterViewModel(new RegisterViewModel());

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            var newmodel = FillModelSelectListItemsForRegisterViewModel(model);
            string ErrorMessage = "";
            if (ModelState.IsValid)
            {
                if (!await _roleManager.RoleExistsAsync("subscriber"))
                {
                    await _roleManager.CreateAsync(new AppRole()
                    {
                        Name = "subscriber"
                    });
                }


                var existUser = await _userManager.FindByNameAsync(newmodel.Email);
                if (existUser != null)
                {
                    TempData[ConstantHelper.ErrorMessage] = "Bu Kullanıcı Zaten Kayıtlı.";
                    return View(model);
                }

                var newUser = new AppUser()
                {
                    Email = newmodel.Email,
                    Country = newmodel.Country,
                    CompanySize = newmodel.CompanySize,
                    TIN = newmodel.TIN,
                    FirstName = newmodel.FirstName,
                    LastName = newmodel.LastName,
                    PhoneNumber = newmodel.PhoneNumber,
                    //Region = model.Region,
                    City = newmodel.City,
                    Sex = newmodel.Sex,
                    CompanyName = newmodel.CompanyName,
                    WebSiteUrl = newmodel.WebSiteUrl,
                    YearOfEstablisment = newmodel.YearOfEstablishment,
                    Zip = newmodel.Zip,
                    UserName = newmodel.Email,
                    RoleId = newmodel.IsBuyer ? ERegisterRoleType.BUYER : ERegisterRoleType.MANUFACTURER,
                };
                var addUser = await _userManager.CreateAsync(newUser, newmodel.Password);
                if (addUser.Succeeded)
                {
                    foreach (var item in newmodel.MyCertifications)
                        _userCertificateService.Add(new UserCertification() { CertificaId = Convert.ToInt32(item), UserId = newUser.Id });
                    foreach (var item in newmodel.IndustriesYourCompanySuppliesTo)
                        _userIndustryService.Add(new UserIndustry() { IndustryId = Convert.ToInt32(item), UserId = newUser.Id });
                    foreach (var item in newmodel.MaterialsYourCompanyProcesses)
                        _userMaterialService.Add(new UserMaterial() { MaterialId = Convert.ToInt32(item), UserId = newUser.Id });
                    foreach (var item in newmodel.TechnologiesYourCompanyUses)
                        _userTechnologyService.Add(new UserTechnology() { TechnologyId = Convert.ToInt32(item), UserId = newUser.Id });
                    await _userManager.AddToRoleAsync(newUser, "subscriber");
                    //send confirmation email

                    string confirmationToken = await _userManager.
                         GenerateEmailConfirmationTokenAsync(newUser);

                    string confirmationLink = Url.Action("ConfirmEmail",
                      "Login", new
                      {
                          userid = newUser.Id,
                          token = confirmationToken
                      },
                       protocol: HttpContext.Request.Scheme);

                    EmailHelper.SendMail(newUser.Email, "isleme.net Email Doğrulama", string.Format("<h3>isleme.net e giriş yapabilmek için lütfen aşağıdaki bağlantıya tıklayınız.</h3><br /><a href={0} target='_blanck'>Go</a>", confirmationLink), true);
                }
                return RedirectToAction("RegisterCompleted");
            }
            else
            {
                foreach (var item2 in ModelState.Values.SelectMany(x => x.Errors).ToList())
                {
                    ErrorMessage += item2.ErrorMessage + "<br />";
                }
                TempData[ConstantHelper.ErrorMessage] = ErrorMessage;
                return View(model);
            }
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View(new LoginViewModel());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            string ErrorMessage = "";
            if (ModelState.IsValid)
            {
                var res = await _userManager.FindByNameAsync(model.username);
                if (res != null)
                {
                    //Kullanıcı Bulundu
                    var checkUserPassword = await _userManager.CheckPasswordAsync(res, model.password);
                    var confirmedEmail = await _userManager.IsEmailConfirmedAsync(res);
                    if (!confirmedEmail)
                    {
                        ErrorMessage = "Mail Adresiniz Henüz Doğrulanmamış.Lütfen Mail Adresinizi Doğrulayınız.";
                        TempData[ConstantHelper.ErrorMessage] = ErrorMessage;
                        return RedirectToAction("Login");

                    }
                    if (checkUserPassword)
                    {
                        var a = await _userManager.GetRolesAsync(res);

                        var signInUser = await _signInManager.PasswordSignInAsync(res, model.password, true, false);

                        if (signInUser.Succeeded)
                        {
                            return RedirectToAction("Index", "Home");
                        }
                        else
                        {
                            ErrorMessage = "Kullanıcı adı veya şifreniz yanlış.Lütfen tekrar deneyiniz.";
                            TempData[ConstantHelper.ErrorMessage] = ErrorMessage;
                            return RedirectToAction("Login");
                        }
                    }
                    else
                    {
                        ErrorMessage = "Kullanıcı adı veya şifreniz yanlış.Lütfen tekrar deneyiniz.";
                        TempData[ConstantHelper.ErrorMessage] = ErrorMessage;
                        return RedirectToAction("Login");
                    }
                }
                ErrorMessage = "Kullanıcı bulunamadı.";
                TempData[ConstantHelper.ErrorMessage] = ErrorMessage;
            }
            else
            {
                foreach (var item in ModelState.Values.SelectMany(x => x.Errors).OrderBy(X => X.ErrorMessage).ToList())
                {
                    ErrorMessage += item.ErrorMessage + "<br />";
                }
                TempData[ConstantHelper.ErrorMessage] = ErrorMessage;
            }
            return RedirectToAction("Login");
        }

        public async Task<IActionResult> ConfirmEmail(string userid, string token)
        {
            try
            {
                var findUser = await _userManager.FindByIdAsync(userid);
                var confirmEmail = await _userManager.ConfirmEmailAsync(findUser, token);
                if (confirmEmail.Succeeded)
                {
                    TempData[ConstantHelper.Success] = "Email Adresiniz Onaylandı.Giriş Yapabilirsiniz.";
                }
                else
                {
                    TempData[ConstantHelper.ErrorMessage] = "Bir Hata Meydana Geldi.";
                }
            }
            catch (Exception ex)
            {
                TempData[ConstantHelper.ErrorMessage] = ex.Message;
            }
            return View("Login");
        }

        public RegisterViewModel FillModelSelectListItemsForRegisterViewModel(RegisterViewModel model)
        {
            var companySizes = _constantService.GetCompanySizes();
            var countries = _constantService.GetCountries();
            var industries = _constantService.GetIndustries();
            var materials = _constantService.GetMaterials();
            var technologies = _constantService.GetTechnologies();
            var certifications = _constantService.GetCertifications();
            var iller = _constantService.GetIller();

            foreach (var item in companySizes)
                model.CompanySizes.Add(new SelectListItem() { Text = item.CountrySize, Value = item.Id.ToString() });
            foreach (var item in countries)
            {

                model.Countrys.Add(new SelectListItem() { Text = item.COUNTRY_NAME, Value = item.Id.ToString(), Selected = item.COUNTRY_NAME.Contains("Turkey") ? true : false });

            }
            foreach (var item in industries)
                model.Industries.Add(new SelectListItem() { Text = item.IndustryName, Value = item.Id.ToString() });
            foreach (var item in materials)
                model.Materials.Add(new SelectListItem() { Text = item.MaterialName, Value = item.Id.ToString() });
            foreach (var item in technologies)
                model.Technogies.Add(new SelectListItem() { Text = item.TechnologyName, Value = item.Id.ToString() });
            foreach (var item in certifications)
                model.Certifications.Add(new SelectListItem() { Text = item.CertificateName, Value = item.Id.ToString() });
            foreach (var item in iller)
                model.Iller.Add(new SelectListItem() { Text = item.Ad.ToUpper(), Value = item.Id.ToString() });
            return model;
        }

        public async Task<IActionResult> ForgotPassword()
        {
            return View();
        }

        public async Task<ActionResult> Signout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login", "Login");
        }

        public IActionResult RegisterCompleted()
        {
            return View();
        }
    }
}