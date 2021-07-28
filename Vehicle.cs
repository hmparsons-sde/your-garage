using System;
using System.Collections.Generic;
using System.Text;

namespace your_garage
{
    class Vehicle
    {
        public int FuelCapacity { get; set; }
        public string Color { get; set; }
        public int PassengerOccupancy { get; set; }

        public void Refueling()
        {
            Console.WriteLine($"The {GetType().Name} is refueling");
        }
    }
}
