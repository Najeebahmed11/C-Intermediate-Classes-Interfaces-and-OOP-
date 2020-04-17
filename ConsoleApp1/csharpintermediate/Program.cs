using ClassLibrary1;
using System;
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
            //value type:they are on the stack.where limit amout mem is allocated to each thread pgm
            //ref type are stoed in heap for longer lifetime eg anyclasses
            //boxing:conversion of value type ref to object type ref
            //value is stored in heap instead of stack
            //clr put object in heap and reference in stack that point to heap
            //unboxing:when we cast an object to integer
            //


        }

    }       
}

