using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wba.FormViewModelExample.Web.ViewModels;

namespace Wba.FormViewModelExample.Web.Controllers
{
    public class EstaController : Controller
    {
        [HttpGet]
        public IActionResult Apply()
        {
            EstaApplyViewModel estaApplyViewModel = new EstaApplyViewModel();
            estaApplyViewModel.ArrivalDate = DateTime.Now;
            //add countries to select list
            estaApplyViewModel.Countries = new List<SelectListItem>()
            {
                new SelectListItem{Value="Be",Text="België"},
                new SelectListItem{Value="Nl",Text="Nederland"},
                new SelectListItem{Value="IT",Text="Italië",Selected=true},
                new SelectListItem{Value="TCH",Text="Tchakkamakka"}
            };
            return View(estaApplyViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Process(EstaApplyViewModel estaApplyViewModel)
        {
            //check for model errors
            if (!ModelState.IsValid)
            //refill the countries list
            {
                estaApplyViewModel.Countries = new List<SelectListItem>()
            {
                new SelectListItem{Value="Be",Text="België"},
                new SelectListItem{Value="Nl",Text="Nederland"},
                new SelectListItem{Value="IT",Text="Italië",Selected=true},
                new SelectListItem{Value="TCH",Text="Tchakkamakka"}
            };
                return View("Apply", estaApplyViewModel);
            }
            return View();
        }
    }
}
