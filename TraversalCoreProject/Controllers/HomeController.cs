using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TraversalCoreProject.Models;

namespace TraversalCoreProject.Controllers
{
	[AllowAnonymous]
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			DateTime d =Convert.ToDateTime(DateTime.Now.ToShortDateString());
            _logger.LogInformation( d + "Index page coming");
			_logger.LogError("Error log coming");
            return View();
		}

		public IActionResult Privacy()
		{
            _logger.LogInformation("Privacy page coming");
            return View();
		}
		public IActionResult Test()
		{
			_logger.LogInformation("Test Page coming");
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
