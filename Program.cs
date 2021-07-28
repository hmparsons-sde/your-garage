using System;
using System.Collections.Generic;
using your_garage.Aircrafts;
using your_garage.Cars;
using your_garage.Watercrafts;

namespace your_garage
{
    class Program
    {
        public static void Main()
        {
            // Build a collection of all vehicles that fly
            // With a single `foreach`, have each vehicle Fly()
            var airCrafts = new List<Aircraft> { new Airplane("pink", 3, 8, "Propeller"), new Helicopter("red", 8, 100, 500) };
            foreach (var airCraft in airCrafts)
            {
                airCraft.Flying();
            }
            // Build a collection of all vehicles that operate on roads
            // With a single `foreach`, have each road vehicle Drive()
            var roadVehicles = new List<Car> { new SubaruImpreza("gunmetal", 400, 5, "car materials idk"), new SubaruForester("navy", 300, 6, true) };
            foreach (var car in roadVehicles)
            {
                car.Driving();
            }
            // Build a collection of all vehicles that operate on water
            // With a single `foreach`, have each water vehicle Drive()
            var waterVehicles = new List<Watercraft> { new CruiseShip("neon", 10, 5000, true), new Dingy("rusty", 15, 12, "humans") };
            foreach (var boat in waterVehicles)
            {
                boat.Driving();
            }
        }
    }
}
