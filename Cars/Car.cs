using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace your_garage.Cars
{
    class Car : Vehicle
    {

        public void Driving()
        {
            Console.WriteLine($"The {Color} car can transport {PassengerOccupancy} people");
        }

        public void Braking()
        {
            Console.WriteLine($"The {Color} is braking");
        }
    }
}
