using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkvariumSimulator
{
    internal class VegetarianFish : Fish
    {
        public Random random = new Random();
        public VegetarianFish(string specie, string _acceptedFoodType, int strength, double hungryPerTick, double dirtyPerTick, int oxygenRequirement, double oxygenpertick) : base(specie, _acceptedFoodType, strength, hungryPerTick, dirtyPerTick, oxygenRequirement, oxygenpertick)
        {
            TypeOfFish = "Vagetarian";
        }

        public void EatPlants(Aquarium AquariumHesIn)
        {
         
           var r = random.Next(0,AquariumHesIn.AllPlants.Count + 1);
            Plant plant = AquariumHesIn.AllPlants[r];
            AquariumHesIn.DirtyMax += 10;


           plant.Health -= 25;
            if (plant.IsPoisonous)
            {
                this.Health -= 30;
                DiesFromPoison();


            }

        }

        public void DiesFromPoison()
        {
            Random rand = new Random();
            var r = rand.Next(0, 10);
            if(r == 0)
            {
                CheckifIsAlive();
            }
        }
    }
}
