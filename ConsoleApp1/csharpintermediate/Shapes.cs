using System;

namespace ClassLibrary1
{
    public abstract class Shapes
    {
        public int width { get; set; }
        public int height { get; set; }
        public abstract void draw();
        public void copy()
        {
            Console.WriteLine("copy shape to clipboard");
        }
        public void select()
        {
            Console.WriteLine("select the shape");
        }
    }
}

