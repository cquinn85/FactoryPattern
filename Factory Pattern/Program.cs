using System;

namespace Factory_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int wheelCount;
            bool input = false;
            do
            {
                Console.WriteLine("Enter the amount of tires for the vehicle you want to create:");

                input = int.TryParse(Console.ReadLine(), out wheelCount);
            } while (input == false);

            //how do you call GetVehicle?
          var vehicle = VehicleFactory.GetVehicle(wheelCount);
            vehicle.Drive();
          
        }
    }
}
