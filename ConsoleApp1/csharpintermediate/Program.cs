using System;

namespace csharpintermediate
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //out classifier
            // var st = int.Parse("aab");
            int numm;
            var ezz = int.TryParse("aab",out numm);
            if (ezz = true)
            {
                Console.WriteLine("conversion failed");
            }
        }
        static void useParams()
        {
            var cal = new calculator();
            Console.WriteLine(cal.Add(1, 2, 3, 4));

        }
        static void usePoints()
        {
            try
            {
                Point point = new Point(10, 20);
                point.Move(new Point(40, 44));
                point.Move(null);
                Console.WriteLine(point.X);
                Console.WriteLine(point.Y);

            }
            catch (Exception)
            {

                Console.WriteLine("there is exception");
            }
        }
    }
}
