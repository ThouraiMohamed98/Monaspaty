using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MonaspatyF.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MonaspatyF.Repository;

namespace MonaspatyF.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        MessageRepository message;
        public HomeController(ILogger<HomeController> logger, MessageRepository message)
        {
            _logger = logger;
            this.message = message;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult contact_us()
        {
            return View();
        }
        [HttpPost]
        public IActionResult contact_us(Message m)
        {
            if(ModelState.IsValid)
            {
                message.add(m);
                return View();
            }
            else
            {
                ViewBag.Message = "invalid Data";
                return View(m);
            }
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
