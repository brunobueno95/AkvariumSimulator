using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkvariumSimulator
{
    internal class CleanerFish : Fish
    {
        public double CleansPerTick { get; set; }   
        public CleanerFish(string specie, string _acceptedFoodType, int strength, double hungryPerTick, double dirtyPerTick, int oxygenRequirement, double oxygenpertick) : base(specie, _acceptedFoodType, strength, hungryPerTick, dirtyPerTick, oxygenRequirement, oxygenpertick)
        {
            TypeOfFish = "cleaner";

        }
    }
}
