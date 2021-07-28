using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace your_garage.Aircrafts
{
    class Aircraft : Vehicle
    {

        public void Flying()
        {
            Console.WriteLine($"The {Color} aircraft is flying");
        }

        public void Landing()
        {
            Console.WriteLine($"The {Color} aircraft with {PassengerOccupancy} passengers is landing");
        }
    }
}
