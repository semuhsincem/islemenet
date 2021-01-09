using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Enums
{
    public enum EMoneyTypes
    {
        [Display(Name ="TRY")]
        TRY = 1,
        [Display(Name = "USD")]
        USD = 2,
        [Display(Name = "EUR")]
        EUR = 1

    }
}
