using LeventDurdali_HW2.Models;
using LeventDurdali_HW2.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;

// Helicopter Model Controller with Index, Detail, Create, Edit and Delete
namespace LeventDurdali_HW2.Controllers
{
    public class HelicopterController : Controller
    {
        private readonly ILogger<HelicopterController> _logger;

        public int PageSize = 4;
        private IHelicopterRepository _repository;

        public object JsonConvert { get; private set; }

        private DroneDBContext _context;

        //Sending repo and context for page useing, sessions, and normal CRUD operations
        public HelicopterController(ILogger<HelicopterController> logger, DroneDBContext context, IHelicopterRepository repository)
        {
            _repository = repository;
            _logger = logger;
            _context = context;
        }

        public IActionResult Index(int page = 1)
        {
            //Page Functionality
            ListViewModel viewModel = new ListViewModel
            {
                Helicopters = _repository.Helicopters.OrderBy(p => p.HelicopterId)
                .Skip((page - 1) * PageSize)
                .Take(PageSize)
,
                PagingInfo = new PagingInfo
                {
                    CurentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = _repository.Helicopters.Count()
                }
            };
            return View(viewModel);
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