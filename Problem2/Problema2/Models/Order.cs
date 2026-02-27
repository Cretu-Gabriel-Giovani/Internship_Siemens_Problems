using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema2.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }

        public List < OrderItem> Items { get; set;} = new List<OrderItem> ();

        public decimal GetTotal()
        {
            return Items.Sum(item => item.GetTotal());
        }
        public decimal GetFinalPrice()
        {
            decimal total = GetTotal();

            if(total > 500)
            {
                total = total * 0.9m;
            }
            return total;
        }
    }

}
