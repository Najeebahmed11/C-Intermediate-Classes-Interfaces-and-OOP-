using System;
using System.Drawing;
using System.Linq;

namespace ConsoleApp1
{
    public class Person
    {
        private DateTime _birthdate;
        public void setBirthdate(DateTime Birthdate)
        {
            _birthdate = Birthdate;

        }
        public DateTime getBirthdate()
        {
            return _birthdate;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.setBirthdate(new DateTime(1997,1,1));
            Console.WriteLine( person.getBirthdate());
        }
    }
}
