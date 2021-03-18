using Microsoft.AspNetCore.Mvc;
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
            return View(estaApplyViewModel);
        }
    }
}
