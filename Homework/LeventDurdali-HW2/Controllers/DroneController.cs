using LeventDurdali_HW2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LeventDurdali_HW2.Controllers
{
    public class DroneController : Controller
    {
        private readonly ILogger<DroneController> _logger;

        DroneDBContext _context;
        public DroneController(ILogger<DroneController> logger, DroneDBContext context)
        {
            _logger = logger;
            _context = context;
        }
        public IActionResult Index()
        {
            var products = _context.Drones.ToList();
            return View(products);
        }
        public IActionResult Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var products = _context.Drones.Where(p => p.DroneId == id).SingleOrDefault();
            if (products == null)
            {
                return NotFound();
            }
            return View(products);
        }
        public IActionResult Create()
        {
            Drone p = new Drone();
            return View(p);
        }
        [HttpPost]
        public IActionResult Create(Drone p)
        {
            _context.Drones.Add(p);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Drone p = _context.Drones.Where(p => p.DroneId == id).SingleOrDefault();
            if (p == null)
            {
                return NotFound();
            }
            return View(p);
        }
        [HttpPost]
        public IActionResult Edit(Drone pmodel)
        {
            if (ModelState.IsValid)
            {
                Drone p = _context.Drones.Where(p => p.DroneId == pmodel.DroneId).SingleOrDefault();
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
            Drone p = _context.Drones.Where(p => p.DroneId == id).SingleOrDefault();

            return View(p);
        }
        [HttpPost]
        public IActionResult Delete(int id, Drone pmodel)
        {
            Drone p = _context.Drones.Where(p => p.DroneId == id).SingleOrDefault();
            if (p != null)
            {
                _context.Drones.Remove(p);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(p);
        }

    }
}
