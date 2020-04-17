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
            var list = new ArrayList();
            list.Add(1);
            list.Add("najeeb");
            list.Add(DateTime.Today);
            //we loose type safety;
            var num = (int)list[1];
            Console.WriteLine(num);
            var anotherlist = new List<int>();


        }

    }       
}

