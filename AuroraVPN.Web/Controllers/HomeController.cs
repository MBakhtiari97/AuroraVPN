using AuroraVPN.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AuroraVPN.Core.DTOs;
using AuroraVPN.Core.Services;

namespace AuroraVPN.Web.Controllers
{
    public class HomeController : Controller
    {
        private INewsletter _newsletter;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger,INewsletter newsletter)
        {
            _logger = logger;
            _newsletter = newsletter;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SubscribeNewsletter(string emailAddress)
        {
            _newsletter.SubscribeToNewsletter(emailAddress);
            return Redirect("/");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

       
    }
}
