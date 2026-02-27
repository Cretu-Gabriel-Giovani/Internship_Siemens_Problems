using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema2.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; } 

        public decimal GetTotal()
        {
            return Quantity * UnitPrice;

        }
    }
}
