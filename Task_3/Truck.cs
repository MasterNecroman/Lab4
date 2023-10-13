using System;

namespace Task_3
{
    public class Truck : Vehicle
    {
        public Truck(double speed, string size) : base("Truck", speed, size) { }

        public override void Optimize()
        {
            Console.WriteLine($"Optimizing speed for the {Type}.");
        }

        public void ChangeRoute(string newRoute)
        {
            Console.WriteLine($"The {Type} is changing its route to {newRoute}.");
        }
    }
}