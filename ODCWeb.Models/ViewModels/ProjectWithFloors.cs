using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODCWeb.Models.ViewModels
{
    public class ProjectWithFloors
    {
        public ODCProject ODCProject { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> Floors { get; set; }

    }
}
