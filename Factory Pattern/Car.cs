using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern
{
    class Car : IVehicle
    {
        public Car()
        {
        }
        //since it conforms to IVehicle, need to implement Drive method
        public void Drive()
        {
            Console.WriteLine("Build a new car!");
        }
    }
}
