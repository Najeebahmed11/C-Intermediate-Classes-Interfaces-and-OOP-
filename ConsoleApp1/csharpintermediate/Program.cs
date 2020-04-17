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
    public class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            Console.ReadLine();


        }

    }       
}

