using Com.Shamiraa.Service.Core.Lib.Helpers;
using System;

namespace Com.Shamiraa.Service.Core.Lib.ViewModels
{
    public class TermOfPaymentViewModel : BasicViewModel
    {
        public string Code { get; set; }
        public string Name { get; set; }

        public bool IsExport { get; set; }
    }
}
