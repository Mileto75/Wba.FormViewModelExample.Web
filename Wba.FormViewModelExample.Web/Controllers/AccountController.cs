using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wba.FormViewModelExample.Web.ViewModels;

namespace Wba.FormViewModelExample.Web.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            //shows the form
            //make a form viewModel
            AccountLoginViewModel accountLoginViewModel = new AccountLoginViewModel();
            //set remember me
            accountLoginViewModel.RememberMe = true;
            return View(accountLoginViewModel);
        }

        [HttpPost]
        public IActionResult Login(AccountLoginViewModel accountLoginViewModel)
        {
            //gets the form data
            string Email = accountLoginViewModel?.Email;
            return Content(Email);
        }
    }
}
