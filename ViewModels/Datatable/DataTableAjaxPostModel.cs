using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ViewModels.Datatable
{
    public class DataTableAjaxPostModel
    {
        [Display(Name = "ŞİRKET BÜYÜKLÜĞÜ*"), Required(ErrorMessage = "ŞİRKET BÜYÜKLÜĞÜ alanı boş geçilemez.")]
        public int CompanySize { get; set; }
        [Display(Name = "ŞİRKET WEB SİTE ADRESİ"), DataType(DataType.Text)]
        public string WebSiteUrl { get; set; }
        [Display(Name = "ŞİRKET MATERYALLERİ*"), DataType(DataType.Text), Required(ErrorMessage = "ŞİRKET MATERYALLERİ alanı boş geçilemez.")]
        public string[] MaterialsYourCompanyProcesses { get; set; }
        [Display(Name = "ŞİRKETİN TEKNOLOJİ KAPASİTESİ*"), DataType(DataType.Text), Required(ErrorMessage = "ŞİRKET TEKNOLOJİ KAPASİTESİ alanı boş geçilemez.")]
        public string[] TechnologiesYourCompanyUses { get; set; }
        [Display(Name = "ŞİRKETİN DESTEK VERDİĞİ ENDÜSTRİLER*"), DataType(DataType.Text), Required(ErrorMessage = "ŞİRKETİN DESTEK VERDİĞİ ENDÜSTRİLER alanı boş geçilemez.")]
        public string[] IndustriesYourCompanySuppliesTo { get; set; }
        [Display(Name = "SERTİFİKALAR*"), DataType(DataType.Text), Required(ErrorMessage = "SERTİFİKALAR alanı boş geçilemez.")]
        public string[] MyCertifications { get; set; }
        public string[] RoleId { get; set; }
        public bool SectorMetal { get; set; }
        public bool SectorWood { get; set; }
        public bool SectorThreeD { get; set; }
        public List<SelectListItem> Materials { get; set; }
        public List<SelectListItem> CompanySizes { get; set; }
        public List<SelectListItem> Countrys { get; set; }
        public List<SelectListItem> Technogies { get; set; }
        public List<SelectListItem> Industries { get; set; }
        public List<SelectListItem> Certifications { get; set; }
        public List<SelectListItem> Iller { get; set; }
    }
}
