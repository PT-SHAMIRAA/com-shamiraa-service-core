using Microsoft.AspNetCore.Mvc;
using Com.Shamiraa.Service.Core.Lib;
using Com.Shamiraa.Service.Core.Lib.Services;
using Com.Shamiraa.Service.Core.WebApi.Helpers;
using Com.Shamiraa.Service.Core.Lib.Models;
using Com.Shamiraa.Service.Core.Lib.ViewModels;

namespace Com.Shamiraa.Service.Core.WebApi.Controllers.v1.UploadControllers
{
    [Produces("application/json")]
    [ApiVersion("1.0")]
    [Route("v{version:apiVersion}/master/upload-buyers")]
    public class BuyersUploadController : BasicUploadController<BuyerService, Buyer, BuyerViewModel, BuyerService.BuyerMap, CoreDbContext>
    {
        private static readonly string ApiVersion = "1.0";
       
        public BuyersUploadController(BuyerService service) : base(service, ApiVersion)
        {
        }
    }
}