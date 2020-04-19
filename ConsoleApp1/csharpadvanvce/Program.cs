
using System;

namespace csharpadvanvce
{
    class Program
        //delegates:that knows how to call method or a group of a method
        //a reference to function
        //for designing extensible and flexible apps
        // use delegates when we have a eveting design pattern
        //or when caller does not need to access other propeties and methods

    {
        static void Main(string[] args)
        {
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();
            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += RemoveRedEyeFilter;

            processor.Process("photo.jpg", filterHandler);
        }

        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("Apply RemoveRedEye");

        }
    }
}
