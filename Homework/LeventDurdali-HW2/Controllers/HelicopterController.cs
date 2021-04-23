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

// Helicopter Model Controller with Index, Detail, Create, Edit and Delete
namespace LeventDurdali_HW2.Controllers
{
    public class HelicopterController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public object JsonConvert { get; private set; }

        DroneDBContext _context;
        public HelicopterController(ILogger<HomeController> logger, DroneDBContext context)
        {
            _logger = logger;
            _context = context;
        }
        public IActionResult Index()
        {




            var products = _context.Helicopters.ToList();
            return View(products);
        }
        public IActionResult Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var products = _context.Helicopters.Where(p => p.HelicopterId == id).SingleOrDefault();
            if (products == null)
            {
                return NotFound();
            }
            return View(products);
        }
        public IActionResult Create()
        {
            Helicopter p = new Helicopter();
            return View(p);
        }
        [HttpPost]
        public IActionResult Create(Helicopter p)
        {
            _context.Helicopters.Add(p);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Helicopter p = _context.Helicopters.Where(p => p.HelicopterId == id).SingleOrDefault();
            if (p == null)
            {
                return NotFound();
            }
            return View(p);
        }
        [HttpPost]
        public IActionResult Edit(Helicopter pmodel)
        {
            if (ModelState.IsValid)
            {
                Helicopter p = _context.Helicopters.Where(p => p.HelicopterId == pmodel.HelicopterId).SingleOrDefault();
                if (p != null)
                {
                    _context.Entry(p).CurrentValues.SetValues(pmodel);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            return View(pmodel);
        }

        public IActionResult Delete(int? id)
        {
            Helicopter p = _context.Helicopters.Where(p => p.HelicopterId == id).SingleOrDefault();

            return View(p);
        }
        [HttpPost]
        public IActionResult Delete(int id, Helicopter pmodel)
        {
            Helicopter p = _context.Helicopters.Where(p => p.HelicopterId == id).SingleOrDefault();
            if (p != null)
            {
                _context.Helicopters.Remove(p);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(p);
        }

    }
}
