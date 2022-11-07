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

        public double DirtyMax { get; set; }

        public double TotalDirtPerTick { get; set; }
        public double TotalOxygenPerTick { get; set; }

        public int OxygenLevel { get; set; }

        public Aquarium(int height, int width, int depth)
        {
            Height = height;
            Width = width;
            Depth = depth;
            DirtyMax = 0;
            AllFishes = new List<Fish>();
        }


        public void AddFish(Fish f)
        {
            AllFishes.Add(f);
        }

        public void AddPlant(Plant p)
        {
            AllPlants.Add(p);
        }
        public void CalculateDirtPerTick()
        {
            TotalDirtPerTick = 0;
            foreach(var fish in AllFishes)
            {
                TotalDirtPerTick += fish.DirtyPerTick;
            }
        }

        public void CalculateOxygenPertick()
        {
            TotalOxygenPerTick = 0;

            foreach(var fish in AllFishes)
            {
                TotalOxygenPerTick += fish.OxygenUsePerTick;
            }
            foreach(var plant in AllPlants)
            {
                TotalOxygenPerTick -= plant.CreateOxygenPerTick;
            }
        }

        // public void CalculateOxygenLevel
        // plants and filter makes oxygen
        // fishes and feeding takes off oxygen
    }
}
