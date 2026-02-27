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

        private const decimal DiscountThreshold = 500m;
        private const decimal DiscountRate = 0.10m;

        public List < OrderItem> Items { get; set;} = new List<OrderItem> ();

        public decimal GetTotal()
        {
            return Items.Sum(item => item.GetTotal());
        }
        public decimal GetFinalPrice()
        {
            var total = GetTotal();

            if(total > DiscountThreshold)
            {
                total = total * (1-DiscountRate);
            }
            return total;
        }
    }

}
