using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkvariumSimulator
{
    internal class CarnivourFish : Fish
    {
        public CarnivourFish(string specie, int strength, double hungryPerTick, double dirtyPerTick, int oxygenRequirement, double oxygenpertick) : base(specie, strength, hungryPerTick, dirtyPerTick, oxygenRequirement, oxygenpertick)
        {
            TypeOfFish = "Carni";
        }
        public CarnivourFish()
        {
            TypeOfFish = "Carni";
            Strength = 10;
            HungryPerTick = 0.3;
            DirtyPerTick = 0.5;
            OxygenRequirement = 10;
            OxygenUsePerTick = 0.03;
            HungryMeter = 200;
                

        }
        public override void Eat()
        {       
           
           var FishesToEat = AquariumHesIn.getListofWeackerFishes(Strength);
            if(FishesToEat.Count > 0)
            {
                Random random = new Random();
                var r = random.Next(0, FishesToEat.Count - 1);
                Hunger -= 30;

                AquariumHesIn.RemoveFish(FishesToEat[r]);
                AquariumHesIn.AddDirt(20);
            }
              

            

        }

    }
}
