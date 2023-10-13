using System;

namespace Task_3
{
    public abstract class Vehicle : IDriveable
    {
        public double Speed { get; set; }
        public string Size { get; set; }
        public string Type { get; protected set; }

        protected Vehicle(string type, double speed, string size)
        {
            Type = type;
            Speed = speed;
            Size = size;
        }

        public virtual void Move()
        {
            Console.WriteLine($"The {Type} is moving at a speed of {Speed} mph.");
        }

        public virtual void Stop()
        {
            Console.WriteLine($"The {Type} has stopped.");
        }

        public virtual void Optimize()
        {
            Console.WriteLine($"Default optimization for {Type}.");
        }
    }
}