using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Wba.FormViewModelExample.Web.ViewModels
{
    public class EstaApplyViewModel
    {
        [Display(Name ="Datum van aankomst:")]
        [DataType(DataType.Date)]
        public DateTime ArrivalDate { get; set; }
        [Display(Name = "Emailadres:")]
        public string Email { get; set; }
        [Display(Name = "Mobiel Tel. Nr.:")]
        public string Telephone { get; set; }
        [Display(Name = "Postcode:")]
        public string ZipCode { get; set; }
        [Display(Name = "Straat en huisnummer:")]
        public string StreetAndNumber { get; set; }
        [Display(Name = "Gemeente:")]
        public string Municipality { get; set; }
        [Display(Name = "Provincie:")]
        public string Region { get; set; }
    }
}
