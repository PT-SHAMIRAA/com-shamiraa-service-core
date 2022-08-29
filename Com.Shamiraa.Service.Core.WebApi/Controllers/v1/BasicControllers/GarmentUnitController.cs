using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Com.Shamiraa.Service.Core.Lib;
using Com.Shamiraa.Service.Core.Lib.Models;
using Com.Shamiraa.Service.Core.Lib.Services;
using Com.Shamiraa.Service.Core.Lib.ViewModels;
using Com.Shamiraa.Service.Core.WebApi.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Com.Shamiraa.Service.Core.WebApi.Controllers.v1.BasicControllers
{
	[Produces("application/json")]
	[ApiVersion("1.0")]
	[Route("v{version:apiVersion}/master/garment-units")]
	public class GarmentUnitController : BasicController<GarmentUnitService, Unit, UnitViewModel, CoreDbContext>
	{
		private new static readonly string ApiVersion = "1.0";

		public GarmentUnitController(GarmentUnitService service) : base(service, ApiVersion)
		{
		}
	}
}