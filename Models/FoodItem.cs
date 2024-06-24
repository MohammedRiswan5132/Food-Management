using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodmanagementSystem.Models
{
    // Food item model
    public class FoodItem
    {
        public int FoodItemId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Qty { get; set; }
    }
}
