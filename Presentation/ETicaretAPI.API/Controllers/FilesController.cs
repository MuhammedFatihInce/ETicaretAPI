﻿using Microsoft.AspNetCore.Mvc;

namespace ETicaretAPI.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class FilesController : Controller
	{
		readonly IConfiguration _configuration;

		public FilesController(IConfiguration configuration)
		{
			_configuration = configuration;
		}

		[HttpGet("[action]")]
		public IActionResult GetBaseStorageUrl()
		{
			return Ok(new
			{
				Url = _configuration["BaseStorageUrl"]
			});
		}

	}
}
