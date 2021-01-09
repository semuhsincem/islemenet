using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ViewModels.RFQ
{
    public class CreateRFQViewModel
    {
        public string Title { get; set; }
        [Required(ErrorMessage = "Miktar Alanı Zorunludur."),Display(Name ="Miktar")]
        public int? Quantity { get; set; }
        [Required(ErrorMessage = "İhtiyaç Tipi Alanı Zorunludur."),Display(Name ="İhtiyaç Tipi")]
        public int Need { get; set; }
        [Required(ErrorMessage = "Bitiş Tarihi Alanı Zorunludur."), Display(Name = "Bitiş Tarihi")]
        public DateTime RFQDeadline { get; set; }
        [Required(ErrorMessage = "Son Teslim Tarihi Alanı Zorunludur."), Display(Name = "Son Teslim Tarihi")]
        public DateTime DeliveryDate { get; set; }
        public string CustomRFQId { get; set; }

        public IFormFileCollection Files { get; set; }
        public IFormFileCollection ThreeDFiles { get; set; }


        //Dimensions
        [Required(ErrorMessage = "Uzunluk Alanı Zorunludur."), Display(Name = "Uzunluk")]
        public int Length { get; set; }
        [Required(ErrorMessage = "Genişlik Alanı Zorunludur."), Display(Name = "Genişlik")]
        public int Width { get; set; }
        [Required(ErrorMessage = "Yükseklik Alanı Zorunludur."), Display(Name = "Yükseklik")]
        public int Height { get; set; }
        [Required(ErrorMessage = "Çap Alanı Zorunludur."), Display(Name = "Çap")]
        public int Diameter { get; set; }
        [Required(ErrorMessage = "Minimum Tolerans Alanı Zorunludur."), Display(Name = "Minimum Tolerans")]
        public int MinTol { get; set; }

        [DataType(DataType.MultilineText)]
        public string BasicInformation { get; set; }
        [Required(ErrorMessage = "Para Birimi Alanı Zorunludur."), Display(Name = "Para Birimi")]
        public string OfferCurrency { get; set; }
        [Required(ErrorMessage = "Yazışma Dili Alanı Zorunludur."), Display(Name = "Yazışma Dili")]
        public string CorrespondenceLanguage { get; set; }
        [Required(ErrorMessage = "Teslim Şartı Alanı Zorunludur."), Display(Name = "Teslim Şartı")]
        public string DeliveryConditions { get; set; }
        [Display(Name = "Parça Sayısı")]
        public int Batches { get; set; }
        [Required(ErrorMessage = "Gizlilik Sözleşmesi Alanı Zorunludur."), Display(Name = "Gizlilik Sözleşmesi")]
        public bool IsSecretCheck { get; set; }
        public int PublicationSettingsId { get; set; }
        public int Continents { get; set; }
        public string PublicationSettings_Countries { get; set; }
        public string Distance { get; set; }
        public string SelectedCountries { get; set; }
        [Required(ErrorMessage = "Materyaller Alanı Zorunludur."), Display(Name = "Materyaller")]
        public string[] SelectedMaterials { get; set; }
        [Required(ErrorMessage = "Teknolojiler Alanı Zorunludur."), Display(Name = "Teknolojiler")]
        public string[] SelectedTechnologies { get; set; }
        [Required(ErrorMessage = "Sertifikalar Alanı Zorunludur."), Display(Name = "Sertifikalar")]
        public string[] SelectedCertifications { get; set; }
        [Required(ErrorMessage = "İl Alanı Zorunludur."), Display(Name = "İl")]
        public string SelectedIl { get; set; }

        public List<SelectListItem> Materials { get; set; }
        public List<SelectListItem> CompanySizes { get; set; }
        public List<SelectListItem> Countrys { get; set; }
        public List<SelectListItem> Technologies { get; set; }
        public List<SelectListItem> Industries { get; set; }
        public List<SelectListItem> Certifications { get; set; }
        public List<SelectListItem> Iller { get; set; }

        public CreateRFQViewModel()
        {
            Batches = 1;
            RFQDeadline = DateTime.Now;
            DeliveryDate = DateTime.Now.AddMonths(1);
            Materials = new List<SelectListItem>();
            CompanySizes = new List<SelectListItem>();
            Countrys = new List<SelectListItem>();
            Technologies = new List<SelectListItem>();
            Industries = new List<SelectListItem>();
            Certifications = new List<SelectListItem>();
            Iller = new List<SelectListItem>();
        }


    }
}
