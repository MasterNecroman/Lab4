using System;
using System.Collections.Generic;

namespace Task_3
{
    class Simulation
    {
        private List<Road> roads;
        private List<Vehicle> vehicles;
        private bool trafficLightGreen;

        public Simulation()
        {
            roads = new List<Road>();
            vehicles = new List<Vehicle>();
            trafficLightGreen = true;
        }

        public void AddRoad(Road road)
        {
            roads.Add(road);
        }

        public void AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        public void SimulateTraffic()
        {
            Console.WriteLine("Simulating traffic at the intersection:");

            foreach (var road in roads)
            {
                Console.WriteLine($"Traffic on road with {road.NumberOfLanes} lane(s)...");
                foreach (var vehicle in vehicles)
                {
                    if (trafficLightGreen)
                    {
                        vehicle.Move();
                    }
                    else
                    {
                        vehicle.Stop();
                    }
                }
            }
        }

        public void ToggleTrafficLight()
        {
            trafficLightGreen = !trafficLightGreen;
            Console.WriteLine("Traffic light is toggled.");
        }

        public void OptimizeTraffic()
        {
            Console.WriteLine("Optimizing traffic...");

            
            foreach (var vehicle in vehicles)
            {
                if (vehicle is Car)
                {
                    Car car = (Car)vehicle;
                    car.ChangeRoute("New Route");
                }
                else if (vehicle is Truck)
                {
                    Truck truck = (Truck)vehicle;
                    truck.ChangeRoute("New Truck Route");
                }
               
            }

            Console.WriteLine("Traffic has been optimized. New traffic patterns are observed.");
        }
    }
}