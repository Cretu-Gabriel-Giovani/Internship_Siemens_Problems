using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Problema2.Models;


namespace Problema2.Services { 
public static class PopularProductsSold
{
    public static  Dictionary<string,int> GetPopularProductsSold(List<Order> orders)

    {
        return orders
            .SelectMany(o => o.Items)
            .GroupBy(item => item.ProductName)
            .ToDictionary(
            group => group.Key,
            group => group.Sum(item => item.Quantity));

    }
}
}