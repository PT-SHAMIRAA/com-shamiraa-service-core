using Com.Shamiraa.Service.Core.Lib;
using Com.Shamiraa.Service.Core.Lib.Models;
using Com.Shamiraa.Service.Core.Lib.Services;
using Com.Shamiraa.Service.Core.Lib.ViewModels;
using Com.Shamiraa.Service.Core.WebApi.Helpers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Com.Shamiraa.Service.Core.WebApi.Controllers.v1.BasicControllers
{

    [Produces("application/json")]
    [ApiVersion("1.0")]
    [Route("v{version:apiVersion}/articles/colors/all")]
    public class ArticleColorController : BasicController<ArticleColorService, ArticleColor, ArticleColorViewModel, CoreDbContext>
    {
        private new static readonly string ApiVersion = "1.0";
        public ArticleColorController(ArticleColorService service) : base(service, ApiVersion)
       {
        }
    }
}
