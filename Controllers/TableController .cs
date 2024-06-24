using FoodmanagementSystem.DAL;
using FoodmanagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodmanagementSystem.Controllers
{
    public class TableController : Controller
    {
        private TableRepository _tableRepository;

        public TableController()
        {
            _tableRepository = new TableRepository();
        }

        // GET: Table
        public ActionResult Index()
        {
            var tables = _tableRepository.GetAllTables();
            return View(tables);
        }


        // POST: Table/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Tables table)
        {
            try
            {
                _tableRepository.UpdateTable(id.ToString(), table.Status);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
