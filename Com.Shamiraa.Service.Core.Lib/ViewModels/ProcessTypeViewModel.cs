﻿using Com.Shamiraa.Service.Core.Lib.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Shamiraa.Service.Core.Lib.ViewModels
{
    public class ProcessTypeViewModel : BasicViewModel
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Remark { get; set; }

        /*order type*/
        public virtual OrderTypeViewModel OrderType { get; set; }

    }
}
