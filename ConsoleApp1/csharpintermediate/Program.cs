using ClassLibrary1;
using System;
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
    class rectangle : shape
    {
        public override void draw()
        {
            base.draw();
        }
    }
    public class shape
    {
        public virtual void draw()
        {
               
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            //method overriding:modifying the implimentation of inherutaed method
            //polymorphism means many forms
            //
        }

    }       
}

