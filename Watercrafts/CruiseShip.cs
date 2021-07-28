using System;
using System.Collections.Generic;
using System.Text;

namespace your_garage.Watercrafts
{
    class CruiseShip : Watercraft
    {
        public bool IsThereAHotTub { get; set; }

        public CruiseShip(string color, int fuelCapacity, int passengerOccupancy, bool isThereAHotTub)
        {
            Color = color;
            FuelCapacity = fuelCapacity;
            PassengerOccupancy = passengerOccupancy;
            IsThereAHotTub = isThereAHotTub;
        }

    }
}
