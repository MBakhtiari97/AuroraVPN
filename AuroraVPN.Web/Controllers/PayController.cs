using System;
using AuroraVPN.Core.Generators;
using Microsoft.AspNetCore.Mvc;

namespace AuroraVPN.Web.Controllers
{
    public class PayController : Controller
    {
        [Route("MakePayment")]
        public IActionResult Pay()
        {
            return View();
        }

        [Route("Payment")]
        [HttpPost]
        public IActionResult SuccessPayment()
        {
            ViewBag.Username = RandomStringGenerator.RandomString(8);
            ViewBag.Password = RandomStringGenerator.RandomString(8);
            return View();
        }
    }
}
