﻿using Microsoft.AspNetCore.Mvc;
using Com.Shamiraa.Service.Core.Lib;
using Com.Shamiraa.Service.Core.Lib.Services;
using Com.Shamiraa.Service.Core.WebApi.Helpers;
using Com.Shamiraa.Service.Core.Lib.Models;
using Com.Shamiraa.Service.Core.Lib.ViewModels;

namespace Com.Shamiraa.Service.Core.WebApi.Controllers.v1.UploadControllers
{
    [Produces("application/json")]
    [ApiVersion("1.0")]
    [Route("v{version:apiVersion}/master/upload-uoms")]
    public class UomsUploadController : BasicUploadController<UomService, Uom, UomViewModel, UomService.UomMap, CoreDbContext>
    {
        private static readonly string ApiVersion = "1.0";

        public UomsUploadController(UomService service) : base(service, ApiVersion)
        {
        }
    }
}