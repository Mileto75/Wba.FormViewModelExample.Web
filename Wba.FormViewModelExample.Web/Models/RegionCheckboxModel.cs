using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wba.FormViewModelExample.Web.Models
{
    public class RegionCheckboxModel
    {
        public string Region { get; set; }
        public long RegionId { get; set; }
        public bool IsSelected { get; set; }
    }
}
