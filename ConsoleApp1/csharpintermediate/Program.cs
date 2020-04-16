using System;
using System.Drawing;
using System.Linq;

namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {
            var ins = new HttpCookie();
            ins["name"] = "Mosh";
            Console.WriteLine(ins["name"]);
            //indexers:a ways to access elements of class that represent list of values
            Console.WriteLine("hello");
        }

    }
}
