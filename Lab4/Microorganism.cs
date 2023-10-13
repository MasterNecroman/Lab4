using System;
using Task_1;

namespace Task_1
{
    public class Microorganism : LivingOrganism, IReproducible, IPredator
    {
        public string Type { get; set; }
        public bool IsPathogenic { get; set; }
        public double Speed { get; set; }
        public int PulsesPerMinute { get; set; }

        public Microorganism(double energy, int age, double size, string type, bool isPathogenic, double speed, int pulsesPerMinute)
            : base(energy, age, size)
        {
            Type = type;
            IsPathogenic = isPathogenic;
            Speed = speed;
            PulsesPerMinute = pulsesPerMinute;
        }

        public void Reproduce()
        {
            Console.WriteLine("The microorganism is reproducing.");
        }

        public void Hunt()
        {
            Console.WriteLine("The microorganism is hunting.");
        }
    }
}