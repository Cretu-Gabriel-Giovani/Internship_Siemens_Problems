using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using Problema2.Models;
using Problema2.Services;

class Program
{
    static void Main()
    {
        var order1 = new Order
        {
            OrderId = 1,
            CustomerName = "Gabi",
            Items = new List<OrderItem>
            {
                new OrderItem { Id = 1, ProductName = "Monitor", Quantity = 1, UnitPrice = 600 },
                new OrderItem { Id = 2, ProductName = "Laptop", Quantity = 3, UnitPrice = 40 }
            }
        };


        var order2 = new Order
        {
            OrderId = 2,
            CustomerName = "Alex",
            Items = new List<OrderItem>
            {
                new OrderItem { Id = 3, ProductName = "Touchpad", Quantity = 5, UnitPrice = 700 },
                new OrderItem { Id = 4, ProductName = "Keyboard", Quantity = 3, UnitPrice = 300 }
            }

        };


        var orders = new List<Order>() { order1, order2 };

        // Discount Test

        Console.WriteLine("Order2 Final Price: " + order2.GetFinalPrice());

        // TopCustomer Test
        Console.WriteLine("Top Customer: " + TopCustomer.GetTopCustomer(orders));

        // PopularProductsSold Test
        var popularProducts = PopularProductsSold.GetPopularProductsSold(orders);

        Console.WriteLine("Popular products:");
        foreach( var product in popularProducts)
        {

            Console.WriteLine($"{product.Key} - {product.Value}");
        }
    }
}
