using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Quote_Website.Models;

namespace Quote_Website.Controllers
{
    public class SelfhostingController : Controller
    {
        private readonly ILogger<SelfhostingController> _logger;

        public SelfhostingController(ILogger<SelfhostingController> logger)
        {
            _logger = logger;
        }

        public IActionResult index()
            => View();

        public IActionResult linux()
            => View();

        public IActionResult windows()
            => View();

        public IActionResult installer()
            => View();

        public IActionResult faq()
            => View();

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
