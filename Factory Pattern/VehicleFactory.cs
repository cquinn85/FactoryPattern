using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern
{
    public static class VehicleFactory
    {
        //can only contain static members
        public static IVehicle GetVehicle(int wheelCount)
        {
            switch (wheelCount)
            {
                case 2:
                    return new Motorcycle();
                case 4:
                    return new Car();
                case 3:
                    return new ThreeWheeler();
                default:
                    return new Car();
            }
        }
    }
}
