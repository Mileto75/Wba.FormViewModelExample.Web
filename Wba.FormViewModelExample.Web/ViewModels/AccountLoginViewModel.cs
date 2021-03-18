using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Wba.FormViewModelExample.Web.ViewModels
{
    public class AccountLoginViewModel
    {
        [Display(Name = "Email:")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage ="Email mag niet leeg zijn!")]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Paswoord:")]
        [Required(ErrorMessage = "Wachtwoord mag niet leeg zijn!")]
        public string Password { get; set; }
        [Display(Name = "Onthoud mij")]
        public bool RememberMe { get; set; }
    }
}
