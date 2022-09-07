using Microsoft.AspNetCore.Mvc;
using Com.Shamiraa.Service.Core.Lib;
using Com.Shamiraa.Service.Core.Lib.Models;
using Com.Shamiraa.Service.Core.Lib.Services;
using Com.Shamiraa.Service.Core.Lib.ViewModels;
using Com.Shamiraa.Service.Core.WebApi.Helpers;


namespace Com.Shamiraa.Service.Core.WebApi.Controllers.v1.BasicControllers
{
    [Produces("application/json")]
    [ApiVersion("1.0")]
    [Route("v{version:apiVersion}/articles/subCounters")]
    public class ArticleSubCountersController : BasicController<ArticleSubCounterService, ArticleSubCounter, ArticleSubCounterViewModel, CoreDbContext>
    {
        private new static readonly string ApiVersion = "1.0";
        public ArticleSubCountersController(ArticleSubCounterService service) : base(service, ApiVersion)
        {
        }
    }
}
