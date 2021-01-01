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
        public int Quantity { get; set; }

        public int Need { get; set; }

        public DateTime RFQDeadline { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string CustomRFQId { get; set; }

        public List<IFormFile> Files { get; set; }
        public List<IFormFile> ThreeDFiles  { get; set; }


        //Dimensions

        public int Length { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Diameter { get; set; }
        public int MinTol { get; set; }

        [DataType(DataType.MultilineText)]
        public string BasicInformation { get; set; }

        public string OfferCurrency { get; set; }
        [Display(Name = "Correspondence Language")]
        public string[] CorrespondenceLanguage { get; set; }
        [Display(Name = "Correspondence Language")]
        public string DeliveryConditions  { get; set; }

        public int PublicationSettingsId { get; set; }
        public int Continents { get; set; }
        public string PublicationSettings_Countries { get; set; }
        public string Distance { get; set; }
        public string[] SelectedCountries { get; set; }

        public List<SelectListItem> Materials { get; set; }
        public List<SelectListItem> CompanySizes { get; set; }
        public List<SelectListItem> Countrys { get; set; }
        public List<SelectListItem> Technogies { get; set; }
        public List<SelectListItem> Industries { get; set; }
        public List<SelectListItem> Certifications { get; set; }

        public CreateRFQViewModel()
        {
            Materials = new List<SelectListItem>();
            CompanySizes = new List<SelectListItem>();
            Countrys = new List<SelectListItem>();
            Technogies = new List<SelectListItem>();
            Industries = new List<SelectListItem>();
            Certifications = new List<SelectListItem>();
        }


    }
}
