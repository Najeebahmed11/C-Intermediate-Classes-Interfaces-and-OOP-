using System;

namespace ClassLibrary1
{
    public class Customer
    {

        public int Id { get; set; }
        public int Name { get; set; }

        public void Promote()
        {
            var call = new RateCal();
            var ratt = call.Calculate(this);

            Console.WriteLine("promoted");
        }
    }
}

