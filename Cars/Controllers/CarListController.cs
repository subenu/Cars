﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cars.Data;
using Cars.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cars.Controllers
{
    public class CarListController : Controller
    {

        private readonly ApplicationDbContext _db; 

        public CarListController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<CarList> objlist = _db.CarList; 
            return View(objlist);
        }

        // GET - CREATE
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        // POST - CREATE
        public IActionResult Create(CarList obj)
        {
            _db.CarList.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
