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
        public IActionResult Register
            (UsersRegisterViewModel usersRegisterViewModel)
        {
            //perform validation
            //store user in Db
            //redirect to ...
            return RedirectToAction("RegistrationSuccess");
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
