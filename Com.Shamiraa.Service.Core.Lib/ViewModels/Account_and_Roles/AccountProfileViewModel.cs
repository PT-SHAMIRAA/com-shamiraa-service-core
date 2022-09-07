using Com.Shamiraa.Service.Core.Lib.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Shamiraa.Service.Core.Lib.ViewModels.Account_and_Roles
{
    public class AccountProfileViewModel : BasicViewModel
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Gender { get; set; }
    }
}
