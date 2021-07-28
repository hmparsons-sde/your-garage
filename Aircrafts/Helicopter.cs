using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace your_garage.Aircrafts
{
    class Helicopter : Aircraft
    {
        public int NumberOfBlades { get; set; }

        public Helicopter(string color, int fuelCapacity, int passengerOccupancy, int numberOfBlades)
        {
            Color = color;
            FuelCapacity = fuelCapacity;
            PassengerOccupancy = passengerOccupancy;
            NumberOfBlades = numberOfBlades;
        }
    }
}
