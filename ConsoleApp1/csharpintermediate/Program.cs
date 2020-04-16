using System;
using System.Drawing;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var cus = new Customers(1, "najeeb");
            cus.Orders.Add(new Order());
            cus.Orders.Add(new Order());
            cus.Orders.Add(new Order());
            cus.Orders.Add(new Order());
            cus.Promote();
            Console.WriteLine(cus.Orders.Count());

        }
    }
}
