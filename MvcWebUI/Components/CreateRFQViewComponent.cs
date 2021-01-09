using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using ViewModels.RFQ;

namespace MvcWebUI.Components
{
    public class CreateRFQViewComponent : ViewComponent
    {
        private readonly IConstantService _constantService;

        public CreateRFQViewComponent(IConstantService constantService)
        {
            _constantService = constantService;
        }
        public IViewComponentResult Invoke()
        {
            return View(FillModelSelectListItemsForCreateRfqViewModel(new CreateRFQViewModel()));
        }

        public CreateRFQViewModel FillModelSelectListItemsForCreateRfqViewModel(CreateRFQViewModel model)
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
                model.Countrys.Add(new SelectListItem() { Text = item.COUNTRY_NAME, Value = item.Id.ToString(), Selected = item.COUNTRY_NAME.Contains("Turkey") });
            foreach (var item in industries)
                model.Industries.Add(new SelectListItem() { Text = item.IndustryName, Value = item.Id.ToString() });
            foreach (var item in materials)
                model.Materials.Add(new SelectListItem() { Text = item.MaterialName, Value = item.Id.ToString() });
            foreach (var item in technologies)
                model.Technologies.Add(new SelectListItem() { Text = item.TechnologyName, Value = item.Id.ToString() });
            foreach (var item in certifications)
                model.Certifications.Add(new SelectListItem() { Text = item.CertificateName, Value = item.Id.ToString() });
            foreach (var item in iller)
                model.Iller.Add(new SelectListItem() { Text = item.Ad.ToUpper(), Value = item.Id.ToString() });
            return model;
        }

    }
}
