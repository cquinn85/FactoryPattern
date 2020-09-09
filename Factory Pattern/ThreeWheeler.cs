using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern
{
    class ThreeWheeler : IVehicle
    {
        public ThreeWheeler()
        {
        }
        public void Drive()
        {
            Console.WriteLine("Lets go mud riding");
        }
    }
}
