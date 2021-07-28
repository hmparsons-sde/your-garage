using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace your_garage.Aircrafts
{
    class Airplane : Aircraft
    {
        public string PlaneType { get; set; }

        public Airplane(string color, int fuelCapacity, int passengerOccupancy, string planeType)
        {
            Color = color;
            FuelCapacity = fuelCapacity;
            PassengerOccupancy = passengerOccupancy;
            PlaneType = planeType;
        }
    }
}
