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

//Default Home Controller 
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

            List<Helicopter> productListA = new List<Helicopter>()
            {
                new Helicopter(){Name="HP laserJet 1200", Description="e123",Category="Cat",Price=1110},
                new Helicopter(){Name="Acer", Description="asde123",Category="Cat",Price=1110}
            };

            List<Helicopter> productListB = new List<Helicopter>()
            {
                new Helicopter(){Name="HP laserJet 1200", Description="e123",Category="Cat",Price=1110},
                new Helicopter(){Name="Acer", Description="asde123",Category="Cat",Price=1110}
            };

            string jsonProducts = JsonSerializer.Serialize(productListA);
            HttpContext.Session.SetString("SessionProductsA", jsonProducts);

            HttpContext.Session.SetJson("SessionProductsB", productListB);

            HttpContext.Session.SetString("SessionVariable1", "Testing123");
            HttpContext.Session.Remove("SessionVariable1");

            return View();
        }

        public IActionResult SessionDisplay()
        {
            string jsonProducts = HttpContext.Session.GetString("SessionProductsA");
            List<Helicopter> productList = JsonSerializer.Deserialize<List<Helicopter>>(jsonProducts);

            List<Helicopter> productList2 = HttpContext.Session.GetJson<List<Helicopter>>("SessionProductsB");

            if (HttpContext.Session.GetString("SessionVariable1") != null)
                ViewBag.Message = HttpContext.Session.GetString("SessionVariable1");
            else
                ViewBag.Message = "No message";

            return View(productList2);

        }

        public IActionResult Clear()
        {
            HttpContext.Session.Clear();
            return View("Privacy");
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
