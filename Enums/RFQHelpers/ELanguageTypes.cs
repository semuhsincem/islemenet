using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Enums
{
    public enum ELanguageTypes
    {
        [Display(Name ="Türkçe")]
        TR = 1,
        [Display(Name = "English")]
        EN = 2,
    }
}
