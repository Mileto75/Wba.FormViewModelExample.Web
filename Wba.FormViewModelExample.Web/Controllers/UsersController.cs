using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wba.FormViewModelExample.Web.ViewModels;

namespace Wba.FormViewModelExample.Web.Controllers
{
    public class UsersController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register
            (UsersRegisterViewModel usersRegisterViewModel)
        {
            //perform validation
            if (ModelState.IsValid)
                //redirect to ...
                return RedirectToAction("RegistrationSuccess");

            return View(usersRegisterViewModel);
        }

        [HttpGet]
        [Route("thanks-for-registering")]
        public IActionResult RegistrationSuccess
            ()
        {
            return View();
        }


    }
}
