using System;
using Task_1;

namespace Task_1
{
    public class Plant : LivingOrganism, IReproducible
    {
        public string Species { get; set; }
        public string Color { get; set; }
        public string SoilType { get; set; } 

        public Plant(double energy, int age, double size, string species, string color, string soilType)
            : base(energy, age, size)
        {
            Species = species;
            Color = color;
            SoilType = soilType; 
        }

        public void Reproduce()
        {
            Console.WriteLine("The plant is reproducing.");
        }
    }
}