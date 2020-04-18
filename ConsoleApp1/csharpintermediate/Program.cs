using ClassLibrary1;
using System.Collections;
using System.Collections.Generic;
using System.IO;
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
            var stream = new Stream();
            //Abstract classes and members:indiacate class or a member is missng implimentation.
            //and we leave it to derive classes to fulfill that implimentation
            //class and function both should be declared abstract
            //fuction should not have a body
            //abstract classes can not intialized
            var crl = new circle();
            crl.draw();
            var rec = new Rectangle();
            rec.draw();
           // var shape = new Shapes();

        }

    }       
}

