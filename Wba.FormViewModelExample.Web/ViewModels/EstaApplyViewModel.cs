using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [Required(ErrorMessage ="Email verplicht")]
        public string Email { get; set; }
        [Display(Name = "Mobiel Tel. Nr.:")]
        [Required(ErrorMessage ="Phone verplicht!")]
        public string Telephone { get; set; }
        [Display(Name = "Postcode:")]
        public string ZipCode { get; set; }
        [Display(Name = "Straat en huisnummer:")]
        public string StreetAndNumber { get; set; }
        [Display(Name = "Gemeente:")]
        public string Municipality { get; set; }
        public List<SelectListItem> Countries { get; set; }
        [DisplayName("Country of origin:")]
        public string CountryId { get; set; }
    }
}
