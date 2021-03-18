using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wba.FormViewModelExample.Web.Services;
using Wba.FormViewModelExample.Web.ViewModels;

namespace Wba.FormViewModelExample.Web.Controllers
{
    public class EstaController : Controller
    {
        private readonly SelectListBuilder _selectListBuilder;

        public EstaController()
        {
            _selectListBuilder = new SelectListBuilder();
        }
        [HttpGet]
        public IActionResult Apply()
        {
            EstaApplyViewModel estaApplyViewModel = new EstaApplyViewModel();
            estaApplyViewModel.ArrivalDate = DateTime.Now;
            //add countries to select list
            estaApplyViewModel.Countries = _selectListBuilder.Countries();
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
                estaApplyViewModel.Countries = _selectListBuilder.Countries();
                return View("Apply", estaApplyViewModel);
            }
            return View();
        }
    }
}
