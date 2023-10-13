using System;

namespace Task_3
{
    class Program
    {
        static Simulation simulation = new Simulation();

        static void Main(string[] args)
        {
            Road road1 = new Road(1000, 2.5, 2, 2);
            Road road2 = new Road(800, 3.0, 3, 1);
            simulation.AddRoad(road1);
            simulation.AddRoad(road2);

            Vehicle car1 = new Car(60, "Medium");
            Vehicle car2 = new Car(70, "Medium");
            Vehicle truck = new Truck(50, "Large");
            simulation.AddVehicle(car1);
            simulation.AddVehicle(car2);
            simulation.AddVehicle(truck);

            DisplayMenuRecursively();
        }

        static void DisplayMenuRecursively()
        {
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Simulate Traffic");
            Console.WriteLine("2. Toggle Traffic Light");
            Console.WriteLine("3. Optimize Traffic");
            Console.WriteLine("4. Exit");

            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    simulation.SimulateTraffic();
                    DisplayMenuRecursively();
                    break;
                case "2":
                    simulation.ToggleTrafficLight();
                    DisplayMenuRecursively();
                    break;
                case "3":
                    simulation.OptimizeTraffic();
                    DisplayMenuRecursively();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    DisplayMenuRecursively();
                    break;
            }
        }
    }
}