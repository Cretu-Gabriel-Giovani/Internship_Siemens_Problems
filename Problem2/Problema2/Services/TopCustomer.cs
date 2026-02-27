using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Problema2.Models;

namespace Problema2.Services
{
    public static class TopCustomer
    {
        public static string GetTopCustomer(List<Order> orders)
        {
            return orders

            .GroupBy(o => o.CustomerName)
            .Select(group => new
            {

                CustomerName = group.Key,
                TotalSpent = group.Sum(o => o.GetFinalPrice())
            })
            .OrderByDescending(x => x.TotalSpent)
            .First()
            .CustomerName;

        }
    }

}