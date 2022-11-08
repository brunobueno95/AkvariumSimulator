using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AkvariumSimulator
{
    internal class App
    {


        public App()
        {
            Aquarium akv = new Aquarium(50,40,120);
            //CarnivourFish c1 = new CarnivourFish("Oscar", 200, 2, 2, 200, 3);
            //CarnivourFish c2 = new CarnivourFish("Oscar", 200, 2, 2, 200, 3);
            //akv.AddFish(c1);
            Plant p = new Plant(5, true);

            akv.addaPLant(p);
          
            //akv.AddFish(c2);
            VegetarianFish v1 = new VegetarianFish();
            VegetarianFish v2 = new VegetarianFish();
            akv.AddFish(v1);
            akv.AddFish(v2);
            CleanerFish cl1 = new CleanerFish("catfish",100,10,0.2,5,2);
            CleanerFish cl2 = new CleanerFish("catfish", 100, 10, 0, 05, 2);
            CleanerFish cl3 = new CleanerFish("catfish", 100, 10, 0, 5, 2);
            CleanerFish cl4 = new CleanerFish("catfish", 100, 10, 0, 5, 2);
            akv.AddFish(cl1);
            akv.AddFish(cl2);
            akv.AddFish(cl3);
            akv.AddFish(cl4);
            akv.AddFilter(new Filter(20, 20));

            DoTheTicks(akv);
            akv.CalculateOxygenLevel();
            akv.checkTotalDirt();
            Console.WriteLine(akv.DirtyMax);
            Console.WriteLine(akv.OxygenLevel);
            foreach(var fish in akv.AllFishes)
            {
                fish.setAquariumFishisIn(akv);
                fish.Eat();
                
            }
            
              Console.WriteLine(akv.AllFishes.Count);
           
            //c1.Eat();
            //c2.Eat();

            
            
            foreach (var fish in akv.AllFishes)
            {
                Console.WriteLine(fish);
            }
            foreach(var plant in akv.AllPlants)
            {
                Console.WriteLine(plant.Health);
            }
            v1.Eat();
            v2.Eat();
            p.CheckIfIsAlive();
            Console.WriteLine(p.IsAlive);
            Console.WriteLine(akv.AllPlants.Count);
            //akv.checkTotalDirt();
            Console.WriteLine(akv.DirtyMax);

        }
        

        private void DoTheTicks(Aquarium akv)
        {
            for(int i =0; i < 10; i++)
            {
                akv.CalculateDirtPerTick();
                akv.CalculateOxygenPertick();
               foreach(var fish in akv.AllFishes)
                {
                    fish.AddToHungryMeter();
                }
            }
        }


       




    }
}
