using Helper.Enums;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ViewModels.Login
{
    public class RegisterViewModel
    {
        public bool IsBuyer { get; set; }
        [Display(Name="ŞİRKET ADI*"),Required(ErrorMessage ="ŞİRKET ADI alanı boş geçilemez.")]
        public string CompanyName { get; set; }
        [Display(Name = "CADDE"),Required(ErrorMessage ="CADDE alanı boş geçilemez.")]
        public string State { get; set; }
        public ERegisterRoleType ERegisterRoleType { get; set; }
        [Display(Name = "TELEFON NUMARASI*"), DataType(DataType.PhoneNumber), Required(ErrorMessage = "TELEFON NUMARASI alanı boş geçilemez.")]
        public string PhoneNumber { get; set; }
        [Display(Name = "POSTA KODU*"), DataType(DataType.PostalCode),  Required(ErrorMessage = "POSTA KODU alanı boş geçilemez.")]
        public string Zip { get; set; }
        [Display(Name = "ŞEHİR*"), DataType(DataType.Text), Required(ErrorMessage = "ŞEHİR alanı boş geçilemez.")]
        public string City { get; set; }
        [Display(Name = "ÜLKE*"), DataType(DataType.Text),  Required(ErrorMessage = "ÜLKE alanı boş geçilemez.")]
        public string Country { get; set; }
        //[Display(Name = "BÖLGE*"), DataType(DataType.Text), Required(ErrorMessage = "BÖLGE alanı boş geçilemez.")]
        //public string Region { get; set; }
        [Display(Name = "SOKAK*"), DataType(DataType.Text), Required(ErrorMessage = "SOKAK alanı boş geçilemez.")]
        public string Street { get; set; }
        //Section 2
        [Display(Name = "CİNSİYETİNİZ*"), Required(ErrorMessage = "CİNSİYET alanı boş geçilemez.")]
        public ESex Sex { get; set; }
        [Display(Name = "ADINIZ*"), DataType(DataType.Text), Required(ErrorMessage = "ADINIZ alanı boş geçilemez.")]
        public string FirstName { get; set; }
        [Display(Name = "SOYADINIZ*"), DataType(DataType.Text), Required(ErrorMessage = "SOYADINIZ alanı boş geçilemez.")]
        public string LastName { get; set; }
        [EmailAddress(ErrorMessage ="Lütfen geçerli bir mail adresi giriniz."),Display(Name ="EMAİL") , Required(ErrorMessage = "EMAİL alanı boş geçilemez.")]
        public string Email { get; set; }
        [DataType(DataType.Password),MinLength(6,ErrorMessage ="Parola Minimum 6 Karakter Olmalı."),Display(Name ="PAROLANIZ*"),Required(ErrorMessage = "PAROLA alanı boş geçilemez.")]
        public string Password { get; set; }
        [DataType(DataType.Password), MinLength(6, ErrorMessage = "Parola Minimum 6 Karakter Olmalı."), Compare(nameof(Password),ErrorMessage ="PAROLA VE PAROLA TEKRAR alanları eşleşmiyor."),Display(Name="PAROLA TEKRAR*"), Required(ErrorMessage = "PAROLA TEKRAR alanı boş geçilemez.")]
        public string RePassword { get; set; }
        [Required(ErrorMessage = "ONAYLAMA FORMU işaretlenmelidir.")]
        public bool IsCheckTheContract { get; set; }
        //Section 3
        [Display(Name = "KURULUŞ TARİHİ*"), DataType(DataType.Text),  Required(ErrorMessage = "KURULUŞ TARİHİ alanı boş geçilemez.")]
        public int YearOfEstablishment {get;set;}
        [Display(Name = "VERGİ NUMARASI*"), DataType(DataType.Text), Required(ErrorMessage = "VERGİ NUMARASI alanı boş geçilemez.")]
        public string TIN {get;set; }
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

        //public bool IsWood { get; set; }
        //public bool IsMetal { get; set; }
        //public bool Is3D { get; set; }

        public string Sector { get; set; }
        public List<SelectListItem> Materials { get; set; }
        public List<SelectListItem> CompanySizes{ get; set; }
        public List<SelectListItem> Countrys { get; set; }
        public List<SelectListItem> Technogies { get; set; }
        public List<SelectListItem> Industries { get; set; }
        public List<SelectListItem> Certifications { get; set; }
        public List<SelectListItem> Iller { get; set; }

        public RegisterViewModel()
        {
            Materials = new List<SelectListItem>();
            CompanySizes = new List<SelectListItem>();
            Countrys = new List<SelectListItem>();
            Technogies = new List<SelectListItem>();
            Industries = new List<SelectListItem>();
            Certifications = new List<SelectListItem>();
            Iller = new List<SelectListItem>();
            YearOfEstablishment = DateTime.Now.Year;
        }

    }
}
