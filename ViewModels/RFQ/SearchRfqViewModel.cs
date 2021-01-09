
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace ViewModels.RFQ
{
    public class SearchRfqViewModel
    {
        public bool IsWood { get; set; }
        public bool IsMetal { get; set; }
        public bool IsThreeD { get; set; }
        public int MaxLength { get; set; }
        public int MinLength { get; set; }
        public int MinWidth{ get; set; }
        public int MaxWidth { get; set; }
        public int MinHeight{ get; set; }
        public int MaxHeight { get; set; }
        public int MinDiameter { get; set; }
        public int MaxDiameter { get; set; }
        public int MinQuantity { get; set; }
        public int MaxQuantity { get; set; }
        public string[] SelectedTechnologies { get; set; }
        public string[] SelectedMaterials { get; set; }
        public string[] SelectedCertifications { get; set; }
        public List<SelectListItem> Technologies { get; set; }
        public List<SelectListItem> Materials { get; set; }
        public List<SelectListItem> Certifications { get; set; }
        public SearchRfqViewModel()
        {
            Technologies = new List<SelectListItem>();
            Materials = new List<SelectListItem>();
            Certifications = new List<SelectListItem>();
        }
    }
}
