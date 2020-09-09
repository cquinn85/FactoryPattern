using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern
{
    class Motorcycle : IVehicle
    {
        public Motorcycle()
        {
        }
        //since it conforms to IVehicle, need to implement Drive method
        public void Drive()
        {
            Console.WriteLine("Build a new truck!");
        }
    
       
    }
}
