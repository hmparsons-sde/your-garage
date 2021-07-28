using System;
using System.Collections.Generic;
using System.Text;

namespace your_garage.Cars
{
    class SubaruImpreza : Car
    {
        public string ConstructionMaterial { get; set; }

        public SubaruImpreza(string color, int fuelCapacity, int passengerOccupancy, string constructionMaterial)
        {
            Color = color;
            FuelCapacity = fuelCapacity;
            PassengerOccupancy = passengerOccupancy;
            ConstructionMaterial = constructionMaterial;
        }
    }
}
