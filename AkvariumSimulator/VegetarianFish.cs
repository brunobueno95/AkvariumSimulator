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
        public VegetarianFish(string specie, int strength, double hungryPerTick, double dirtyPerTick, int oxygenRequirement, double oxygenpertick) : base(specie, strength, hungryPerTick, dirtyPerTick, oxygenRequirement, oxygenpertick)
        {
            TypeOfFish = "vegetarian";
            HungryMeter = 200;
        }

        public VegetarianFish()
        {
            TypeOfFish = "vegetarian";
            
            Health = 20;
            Strength = 10;
            HungryPerTick = 0.05;
            DirtyPerTick = 0.1;
            OxygenRequirement = 10;
            OxygenUsePerTick = 0.01;
            HungryMeter = 200;

        }

        public override void Eat()
        {

           var r = random.Next(0,AquariumHesIn.AllPlants.Count - 1);
           var plantToEat = AquariumHesIn.AllPlants[r];
            AquariumHesIn.AddDirt(20);
            Hunger -= 30;


            plantToEat.LooseHealh(25);
          
            if (plantToEat.IsPoisonous)
            {
                this.Health -= 40;
                DiesFromPoison();
           }

        }
       

     

        private void DiesFromPoison()
        {
            if(Health > 0)
            {
                Random rand = new Random();
                var r = rand.Next(0, 10);
                if (r == 0)
                {
                    Health = 0;
                    CheckifIsAlive();
                }
            }
            else
            {
                CheckifIsAlive();
            }
          
        }
    }
}
