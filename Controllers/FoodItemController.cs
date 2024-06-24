using FoodmanagementSystem.DAL;
using FoodmanagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodmanagementSystem.Controllers
{
    public class FooditemController : Controller
    {
        private FoodItemRepository _fooditemRepository;

        public FooditemController()
        {
            _fooditemRepository = new FoodItemRepository();
        }

       
        }
    }
