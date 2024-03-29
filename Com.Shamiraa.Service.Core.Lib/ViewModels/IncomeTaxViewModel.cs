﻿using Com.Shamiraa.Service.Core.Lib.Helpers;
using System;

namespace Com.Shamiraa.Service.Core.Lib.ViewModels
{
    public class IncomeTaxViewModel : BasicViewModel
    {
        public string code { get; set; }

        public string name { get; set; }

        /* Double */
        public dynamic rate { get; set; }

        public string description { get; set; }

        public string COACodeCredit { get; set; }
    }
}
