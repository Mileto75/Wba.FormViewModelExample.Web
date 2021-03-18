using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wba.FormViewModelExample.Web.Services
{
    public class SelectListBuilder
    {
        public List<SelectListItem> Countries()
        {
            return new List<SelectListItem>
            {
                new SelectListItem{Value="Be",Text="België"},
                new SelectListItem{Value="Nl",Text="Nederland"},
                new SelectListItem{Value="IT",Text="Italië",Selected=true},
                new SelectListItem{Value="TCH",Text="Tchakkamakka"}
            };
        }

        public List<SelectListItem> Regions()
        {
            return new List<SelectListItem>
            {
                new SelectListItem{Value="Ovl",Text="Oost-Vlaanderen"},
                new SelectListItem{Value="Wvl",Text="West-Vlaanderen"},
                new SelectListItem{Value="Bru",Text="Brussel",Selected=true},
                new SelectListItem{Value="Park",Text="Tchakkamakka"}
            };
        }


    }
}
