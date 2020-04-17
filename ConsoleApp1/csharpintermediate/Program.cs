using ClassLibrary1;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading;
using System.Threading.Channels;

namespace ClassLibrary1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //constructors inheritance
            //base class constructors are always executed first
            //base class constructors are always not inheritaed
            //so in a derived class you need to redefine your construtors
            //we use :base()
            var car = new Car("xyz 123");
            
        }

    }       
}

