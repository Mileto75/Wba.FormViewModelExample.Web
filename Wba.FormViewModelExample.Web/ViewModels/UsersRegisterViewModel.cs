using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Wba.FormViewModelExample.Web.Models;

namespace Wba.FormViewModelExample.Web.ViewModels
{
    public class UsersRegisterViewModel
    {
        [Display(Name ="Email:")]
        [DataType(DataType.EmailAddress)]
        public string UserName { get; set; }
        [Display(Name = "Voornaam:")]
        public string Firstname { get; set; }
        [Display(Name = "Naam:")]
        public string Lastname { get; set; }
        [Display(Name = "Geef een paswoord in:")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Herhaal uw paswoord:")]
        public string RepeatPassword { get; set; }
        public List<SelectListItem> Countries { get; set; }
        [Display(Name="Land:")]
        public int CountryId { get; set; }

        public List<RegionCheckboxModel> Regions { get; set; }
    }
}
