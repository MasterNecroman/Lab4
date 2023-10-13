using System;

namespace Task_3
{
    public class Car : Vehicle
    {
        public Car(double speed, string size) : base("Car", speed, size) { }

        public override void Optimize()
        {
            Console.WriteLine($"Optimizing route for the {Type}.");
        }

        public void ChangeRoute(string newRoute)
        {
            Console.WriteLine($"The {Type} is changing its route to {newRoute}.");
        }
    }
}