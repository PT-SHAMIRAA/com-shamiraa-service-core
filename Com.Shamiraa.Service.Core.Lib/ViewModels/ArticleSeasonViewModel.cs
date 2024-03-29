﻿using Com.Shamiraa.Service.Core.Lib.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Shamiraa.Service.Core.Lib.ViewModels
{
    public class ArticleSeasonViewModel : BasicViewModelOld
    {
        public string code { get; set; }

        public string name { get; set; }

        public string Description { get; set; }
        public DateTimeOffset Date { get; set; }
    }
}
