﻿using Com.Shamiraa.Service.Core.Lib.Helpers;
using System;

namespace Com.Shamiraa.Service.Core.Lib.ViewModels
{
    public class GarmentCurrencyViewModel : BasicViewModel
    {

        public string code { get; set; }

        public DateTime date { get; set; }

        /* Double */
        public dynamic rate { get; set; }
    }
}
