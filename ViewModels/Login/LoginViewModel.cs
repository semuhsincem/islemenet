using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ViewModels.Login
{
    public class LoginViewModel
    {
        [Display(Name ="EMAİL"),DataType(DataType.Text),Required(ErrorMessage ="Email Alanı Boş Olamaz.")]
        public string username { get; set; }
        [Display(Name ="PAROLA"),DataType(DataType.Password),Required(ErrorMessage = "Şifre Alanı Boş Olamaz.")]
        public string password { get; set; }

    }
}
