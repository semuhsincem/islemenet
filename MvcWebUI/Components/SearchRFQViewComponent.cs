using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ViewModels.RFQ;

namespace MvcWebUI.Components
{
    public class SearchRFQViewComponent : ViewComponent
    {
        public IConstantService _constantService { get; set; }
        public SearchRFQViewComponent(IConstantService constantService)
        {
            _constantService = constantService;
        }
        public IViewComponentResult Invoke()
        {
            var res = FillModel();
            return View(res);
        }
        public SearchRfqViewModel FillModel()
        {
            var model = new SearchRfqViewModel();
            _constantService.GetCertifications().ForEach(x=> {
                model.Certifications.Add(new SelectListItem()
                {
                    Text = x.CertificateName,
                    Value = x.Id.ToString()
                });
            });
            _constantService.GetMaterials().ForEach(x => {
                model.Materials.Add(new SelectListItem()
                {
                    Text = x.MaterialName,
                    Value = x.Id.ToString()
                });
            });
            _constantService.GetTechnologies().ForEach(x => {
                model.Technologies.Add(new SelectListItem()
                {
                    Text = x.TechnologyName,
                    Value = x.Id.ToString()
                });
            });
            return model;
        }
    }
   
}
