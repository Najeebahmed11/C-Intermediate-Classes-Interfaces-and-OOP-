using ConsoleApp2.Maths;
using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Channels;
using System.IO;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var cutom = new Customer(1,"najeeb");
            var order = new Order();
            cutom.Orders.Add(order);
            Console.WriteLine(cutom.id);
            Console.WriteLine(cutom.name);
        }

    }
}




