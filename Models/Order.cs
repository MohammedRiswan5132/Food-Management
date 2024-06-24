using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodmanagementSystem.Models
{
    // Order model
    public class Order
    {
        public int OrderId { get; set; }
        public int TableId { get; set; }
        public int FoodItemId { get; set; }
        public int Quantity { get; set; }
        public string OrderStatus { get; set; }
    }
}
