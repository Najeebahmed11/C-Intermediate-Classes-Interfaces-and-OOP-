using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace csharpadvanvce
{
    class Program
    {
          
        static void Main(string[] args)
        {
            //Extension Method:allow us to add method to exsisting class without changing its source code
            string post = "very very long blog post cbchbc";
            var shortenedPost = post.shorten(5);
            IEnumerable<int> numbers = new List<int>() {1,2,3,4,5 };
            
            Console.WriteLine(numbers.Max());
        }
    }
}
