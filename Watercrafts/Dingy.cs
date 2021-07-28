using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace your_garage.Watercrafts
{
    class Dingy : Watercraft
    {
        public string DingyType { get; set; }

        public Dingy(string color, int fuelCapacity, int passengerOccupancy, string dingyType)
        {
            Color = color;
            FuelCapacity = fuelCapacity;
            PassengerOccupancy = passengerOccupancy;
            DingyType = dingyType;
        }

    }
}
