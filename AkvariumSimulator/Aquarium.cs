using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace AkvariumSimulator
{
    internal class Aquarium
    {
        
        public List<Fish> AllFishes { get; set; }

        public Filter Afilter { get; set; }

        public List<Plant> AllPlants {get; set;}

        private int Volume { get; set; }

        public int Height { get; set; }

        public int Depth { get; set; }

        public int Width { get; set; }

        public bool Dirty { get; set; } // if is dirty oxygen go down faster. Loses health as well?

        public double DirtyMax { get; private set; }

        public  double TotalDirtPerTick { get; set; }
        public double TotalOxygenUsedPerTick { get; set; }

        public double OxygenLevel { get; set; }

        public Aquarium(int height, int width, int depth)
        {
            Height = height;
            Width = width;
            Depth = depth;
            DirtyMax = 0;
            AllFishes = new List<Fish>();
            AllPlants = new List<Plant>();
            calculateVolume();
        }


        public void AddFilter(Filter afilter)
        {
            Afilter = afilter;
        }
        public void calculateVolume()
        {
            Volume = Height * Width * Depth;
        }

        public void AddFish(Fish f)
        {
            AllFishes.Add(f);
        }
        public void addaPLant(Plant p)
        {

            AllPlants.Add(p);
        }        
        public void  checkTotalDirt()
        {
            DirtyMax += TotalDirtPerTick;
        }
        public void CalculateDirtPerTick()
        {
            TotalDirtPerTick = 0;
            foreach(var fish in AllFishes)
            {
                TotalDirtPerTick += fish.DirtyPerTick;
            }
            TotalDirtPerTick -= Afilter.CleansPerTick;
        }

        public void CalculateOxygenPertick()
        {
            //TotalOxygenUsedPerTick = 0;
            //List<CleanerFish> CleanerFishes = AllFishes.FindAll(f => f.TypeOfFish == "cleaner"); //#TODO: ask Terje about this.


            TotalOxygenUsedPerTick += Afilter.CreatesOxygenPerTick;
            
            foreach (var fish in AllFishes)
            {
                TotalOxygenUsedPerTick -= fish.OxygenUsePerTick;
            }
            foreach(var plant in AllPlants)
            {
                TotalOxygenUsedPerTick += plant.CreateOxygenPerTick;
            }
        }

        public void CalculateOxygenLevel()
        {
            if(TotalOxygenUsedPerTick < 0)
            {
                OxygenLevel -= TotalOxygenUsedPerTick;
            }
            else
            {
                OxygenLevel += TotalOxygenUsedPerTick;
            }
           

        }
        public void RemoveDirt(int amount)
        {
            DirtyMax -= amount;
        }

        public void AddDirt(int amount)
        {
            DirtyMax += amount;
        }
        public void RemoveFish(Fish fishremoved)
        {
            AllFishes.Remove(fishremoved);
        }
        public void RemovePlant(Plant plantremoved)
        {
            AllPlants.Remove(plantremoved);
        }

        public List<Fish> getListofWeackerFishes( int strentghCarnivour)
        {
            var FishestoEat = new List<Fish>();
             FishestoEat = AllFishes.FindAll(f => f.Strength < strentghCarnivour);
            return FishestoEat;

        }
        
    }
}
