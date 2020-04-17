using System;

namespace ConsoleApp1
{
    class Presenationobject
    {
        public int Width { get; set; }
        public int Hight { get; set; }
        public void Copy()
        {
            Console.WriteLine("object copied");
        }
        public void Duplicate()
        {
            Console.WriteLine("object duplicated");
        }

    }

}

