﻿using System;
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
	[Route("v{version:apiVersion}/master/garment-suppliers")]
	public class GarmentSuppliersController : BasicController<GarmentSupplierService, GarmentSupplier, GarmentSupplierViewModel, CoreDbContext>
	{
		private new static readonly string ApiVersion = "1.0";

		public GarmentSuppliersController(GarmentSupplierService service) : base(service, ApiVersion)
		{
		}
	}
}