using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkvariumSimulator
{
    internal class CleanerFish : Fish
    {
        //public double CleansPerTick { get; set; }   
        public CleanerFish(string specie, int strength, double hungryPerTick, double dirtyPerTick, int oxygenRequirement, double oxygenpertick) : base(specie,  strength, hungryPerTick, dirtyPerTick, oxygenRequirement, oxygenpertick)
        {
            TypeOfFish = "cleaner";
            

        }

        public override void Eat()
        {
            AquariumHesIn.RemoveDirt(30);
            Hunger -= 50;
        }
    }
}
