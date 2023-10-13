using System;
using System.Collections.Generic;

namespace Task_1
{
    public class Ecosystem
    {
        private List<LivingOrganism> organisms = new List<LivingOrganism>();

        public void AddOrganism(LivingOrganism organism)
        {
            organisms.Add(organism);
        }

        public void SimulateEcosystem(bool isNight)
        {
            foreach (var organism in organisms)
            {
                Console.WriteLine($"Organism: {organism.GetType().Name}");
                Console.WriteLine($"Energy: {organism.Energy}");
                Console.WriteLine($"Age: {organism.Age}");
                Console.WriteLine($"Size: {organism.Size}");

                if (organism is IReproducible reproducible)
                {
                    reproducible.Reproduce();
                }

                if (organism is IPredator predator && organism is Animal animal)
                {
                    animal.IsNight = isNight;
                    if (!isNight)
                    {
                        predator.Hunt();
                    }
                    else
                    {
                        Console.WriteLine($"It's night, so {animal.Species} can't hunt.");
                    }
                }

                if (organism is Plant plant)
                {
                    Console.WriteLine($"Soil Type: {plant.SoilType}");
                }

                if (organism is Microorganism microorganism)
                {
                    Console.WriteLine($"Pulses Per Minute: {microorganism.PulsesPerMinute}");
                }

                Console.WriteLine();
            }
        }
    }
}