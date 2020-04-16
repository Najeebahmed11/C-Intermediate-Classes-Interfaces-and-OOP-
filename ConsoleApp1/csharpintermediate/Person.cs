using System;
using System.Dynamic;
using System.Reflection;

namespace ConsoleApp1
{
    public class Person
    {
        public string Name{ get; set;}
        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }
        public DateTime Birthdate{ get;private set; }
        public int age
        {
            get
            {
                var timespan= DateTime.Today - Birthdate;
                var years = timespan.Days / 365;
                return years;
            }
        }
    }
}
