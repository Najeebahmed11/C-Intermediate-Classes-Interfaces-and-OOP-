using System;

namespace ClassLibrary1
{
    public class Vehicle
    {
        private readonly string regNumber;

       // public Vehicle()
        //{
          //  Console.WriteLine("vehicle is being intialized");

        //}
        public Vehicle(string regNumber)
        { 
            this.regNumber = regNumber;

            Console.WriteLine("vehicle is being intialized.{0}", regNumber);
        }
    }
}

