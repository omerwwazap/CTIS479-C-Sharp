using LeventDurdali_HW2.Infrastructure;
using LeventDurdali_HW2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

//Default Home Controller with Session controllers
namespace LeventDurdali_HW2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //Added these to the session
            List<Helicopter> productListB = new List<Helicopter>()
            {
                new Helicopter(){Name="Session Helicopter", Description="Very Cool Session - 1",Category="Session Demonstration - 1",Price=100},
                new Helicopter(){Name="Session Drone", Description="Very Cool Session - 2",Category="Session Demonstration - 2",Price=100}
            };

            HttpContext.Session.SetJson("SessionProductsB", productListB);

            HttpContext.Session.SetString("SessionVariable1", "Master Session Demonstration - HW2");

            return View();
        }
        //for displaying the session elements
        public IActionResult SessionDisplay()
        {

            List<Helicopter> productList2 = HttpContext.Session.GetJson<List<Helicopter>>("SessionProductsB");

            if (HttpContext.Session.GetString("SessionVariable1") != null)
                ViewBag.Message = HttpContext.Session.GetString("SessionVariable1");
            else
                ViewBag.Message = "No Message was added to the session or The Session was deleted beforehand";

            return View(productList2);

        }
        //Demonstration session clear, than re directs to the display to show deletion
        public IActionResult Clear()
        {
            HttpContext.Session.Clear();
            return View("SessionDisplay");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
