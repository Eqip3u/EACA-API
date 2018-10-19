﻿using Microsoft.AspNetCore.Mvc;

namespace EACA_API.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [Route("/")]
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
    }
}