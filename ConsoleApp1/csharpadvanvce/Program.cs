using System;
using System.Collections.Generic;
using System.Linq;

namespace csharpadvanvce
{
    class Program
    {
        public static void Main(string[] args)
        {
            //a value type can not be null
            DateTime  ? date = null;
            DateTime date2=date ?? DateTime.Today;
            //value type can be easily converted into nullable type
            //nul-coelsing operator
        
            Console.WriteLine(date2);
        }
    }
}
