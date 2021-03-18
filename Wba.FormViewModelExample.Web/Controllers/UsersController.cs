using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wba.FormViewModelExample.Web.Models;
using Wba.FormViewModelExample.Web.ViewModels;

namespace Wba.FormViewModelExample.Web.Controllers
{
    public class UsersController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            UsersRegisterViewModel usersRegisterViewModel = new UsersRegisterViewModel();
            usersRegisterViewModel.Countries = new List<SelectListItem>();
            usersRegisterViewModel.Countries.Add(new SelectListItem { Text = "België", Value = "1" });
            usersRegisterViewModel.Countries.Add(new SelectListItem { Text = "Nederland", Value = "2" });
            usersRegisterViewModel.Countries.Add(new SelectListItem { Text = "Duitsland", Value = "3" });
            usersRegisterViewModel.Countries.Add(new SelectListItem { Text = "Italië", Value = "4" });

            usersRegisterViewModel.Regions = new List<RegionCheckboxModel>
            {
                new RegionCheckboxModel{Region="W-vl",RegionId=1,IsSelected=true },
                new RegionCheckboxModel{Region="O-vl",RegionId=2,IsSelected=true },
                new RegionCheckboxModel{Region="Ant",RegionId=3,IsSelected=true },
            };
            return View(usersRegisterViewModel);
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
