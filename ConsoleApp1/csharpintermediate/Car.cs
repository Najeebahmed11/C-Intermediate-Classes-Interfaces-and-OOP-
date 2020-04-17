using System;

namespace ClassLibrary1
{
    public class Car : Vehicle
    {
        public Car(string regist)
            :base(regist)
        {
            Console.WriteLine("car is being intialized.{0}",regist);
        }
    }
}

