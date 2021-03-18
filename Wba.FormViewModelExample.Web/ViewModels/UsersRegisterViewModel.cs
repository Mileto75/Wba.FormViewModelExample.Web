﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

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
    }
}
