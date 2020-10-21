using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cars.Data;
using Cars.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cars.Controllers
{
    public class PlaneListController : Controller
    {
        private readonly ApplicationDbContext _db;

        public PlaneListController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<PlaneList> objlist = _db.PlaneList;
            return View(objlist);
        }

        // GET - CREATE
        public IActionResult Create()
        {
            return View();
        }
        
        // POST - CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(PlaneList obj)
        {
            _db.PlaneList.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
