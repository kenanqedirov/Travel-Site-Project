﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Controllers
{
    [AllowAnonymous]
    public class ErrorPageController : Controller
    {
        public IActionResult Error404(int code)
        {
            return View();
        }
    }
}
