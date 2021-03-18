using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wba.FormViewModelExample.Web.ViewModels
{
    public class UsersRegisterViewModel
    {
        public string UserName { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Password { get; set; }
        public string RepeatPassword { get; set; }
    }
}
