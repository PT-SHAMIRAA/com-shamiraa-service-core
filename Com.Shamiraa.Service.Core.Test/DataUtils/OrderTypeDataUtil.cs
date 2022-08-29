using Com.Shamiraa.Service.Core.Lib;
using Com.Shamiraa.Service.Core.Lib.Models;
using Com.Shamiraa.Service.Core.Lib.Services;
using Com.Shamiraa.Service.Core.Lib.ViewModels;
using Com.Shamiraa.Service.Core.Test.Helpers;
using Com.Shamiraa.Service.Core.Test.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Com.Shamiraa.Service.Core.Test.DataUtils
{
    public class OrderTypeDataUtil : BasicDataUtil<CoreDbContext, OrderTypeService, OrderType>, IEmptyData<OrderTypeViewModel>
    {
        public OrderTypeDataUtil(CoreDbContext dbContext, OrderTypeService service) : base(dbContext, service)
        {
        }

        public OrderTypeViewModel GetEmptyData()
        {
            return new OrderTypeViewModel();
        }

        public override OrderType GetNewData()
        {
            string guid = Guid.NewGuid().ToString();

            return new OrderType()
            {
                Code = string.Format("TEST", guid),
                Name = string.Format("TEST", guid),
                Remark = "REMARK",
            };
        }

        public override async Task<OrderType> GetTestDataAsync()
        {
            var data = GetNewData();
            await this.Service.CreateModel(data);
            return data;
        }
    }
}
