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
    public class Person
    {
        public string name;
        public void introduction(string me)
        {
            Console.WriteLine("hi {0},I am {1}", me, name);
        }
        public static Person parse(string str)
        {
            var person = new Person();
            person.name = str;
            return person;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var person = Person.parse("ahmed");
            person.introduction("najeeb");
        }

    }
}




