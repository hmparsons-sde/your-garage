using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace your_garage.Cars
{
    class SubaruForester : Car
    {
        public bool IsElectric { get; set; }

        public SubaruForester(string color, int fuelCapacity, int passengerOccupancy, bool isElectric)
        {
            Color = color;
            FuelCapacity = fuelCapacity;
            PassengerOccupancy = passengerOccupancy;
            IsElectric = isElectric;
        }
    }
}
