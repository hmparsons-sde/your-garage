using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace your_garage.Watercrafts
{
    class Watercraft : Vehicle
    {

        public void Driving()
        {
            Console.WriteLine($"The {Color} watercraft is carrying {PassengerOccupancy} passengers");
        }
    }
}
