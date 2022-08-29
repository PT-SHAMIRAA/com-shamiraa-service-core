using Com.Shamiraa.Service.Core.Lib.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Com.Shamiraa.Service.Core.Lib.ViewModels
{
    public class ComodityViewModel : BasicViewModel
    {
        public string Code { get; set; }
        public string Name { get; set; }

    }
}
