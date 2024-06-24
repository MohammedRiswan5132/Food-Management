using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodmanagementSystem.Models
{
    // Table model
    public class Tables
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int Capacity { get; set; }
        public string Status { get; set; }
    }
}
