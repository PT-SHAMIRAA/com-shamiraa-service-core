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
    public class DesignMotiveDataUtil : BasicDataUtil<CoreDbContext, DesignMotiveService, DesignMotive>, IEmptyData<DesignMotiveViewModel>
    {
        public DesignMotiveDataUtil(CoreDbContext dbContext, DesignMotiveService service) : base(dbContext, service)
        {
        }

        public DesignMotiveViewModel GetEmptyData()
        {
            return new DesignMotiveViewModel();
        }

        public override DesignMotive GetNewData()
        {
            string guid = Guid.NewGuid().ToString();

            return new DesignMotive()
            {
                Code = string.Format("TEST {0}", guid),
                Name = string.Format("TEST {0}", guid),
            };
        }

        public override async Task<DesignMotive> GetTestDataAsync()
        {
            var data = GetNewData();
            await this.Service.CreateModel(data);
            return data;
        }
    }
}
