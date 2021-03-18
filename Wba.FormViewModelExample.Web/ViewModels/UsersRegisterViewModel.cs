using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Wba.FormViewModelExample.Web.ViewModels
{
    public class UsersRegisterViewModel
    {
        [Display(Name ="Email:")]
        [EmailAddress(ErrorMessage ="Geef geldig adres in!")]
        [Required(ErrorMessage ="Email Verplicht!")]
        
        public string UserName { get; set; }
        [Display(Name = "Voornaam:")]
        [Required(ErrorMessage = "FirstName verplicht!")]
        public string Firstname { get; set; }
        [Display(Name = "Naam:")]
        [Required(ErrorMessage = "Naam verplicht!")]
        public string Lastname { get; set; }
        [Display(Name = "Geef een paswoord in:")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Paswoord verplicht!")]
        [StringLength(6,ErrorMessage ="Paswoord moet tussen 2 en 6 karakters lang zijn",MinimumLength =2)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Herhaal paswoord verplicht!")]
        [Display(Name = "Herhaal uw paswoord:")]
        [Compare("Password",ErrorMessage ="Paswoorden moeten gelijk zijn!")]
        //[StringLength(6, ErrorMessage = "Herhaal Paswoord moet tussen 2 en 6 karakters lang zijn", MinimumLength = 2)]
        public string RepeatPassword { get; set; }
    }
}
