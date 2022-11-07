using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkvariumSimulator
{
    internal class CarnivourFish : Fish
    {
        public CarnivourFish(string specie, string _acceptedFoodType) : base(specie, _acceptedFoodType)
        {
           
        }

        public void EatFish(Aquarium AquariumHesIn)
        {
            if(isHungry == true)
            {
               var FishestoEat = AquariumHesIn.AllFishes.FindAll(f => f.Strength < this.Strength);
                Random random = new Random();
                var r = random.Next(0,FishestoEat.Count + 1);
                AquariumHesIn.AllFishes.Remove(FishestoEat[r]);

            }

            else
            {

            }
        }
    }
}
