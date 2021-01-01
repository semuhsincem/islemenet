using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModels.Login;

namespace MvcWebUI.Models
{
    public class RegisterReturnViewModel
    {
        public RegisterViewModel RegisterViewModel { get; set; }

        public List<string> Errors { get; set; }
        public bool IsSuccess { get; set; }

        public RegisterReturnViewModel()
        {
            RegisterViewModel = new RegisterViewModel();
            Errors = new List<string>();
        }
    }
}
