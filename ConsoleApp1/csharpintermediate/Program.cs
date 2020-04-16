using System;
using System.Drawing;
using System.Linq;

namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {
            var age = new Person(new DateTime(1997, 8, 14));
            
            Console.WriteLine(age.age);
        }

    }
}
