using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public int OxygenLevel { get; set; }

        public Aquarium(int height, int width, int depth)
        {
            Height = height;
            Width = width;
            Depth = depth; 
        }


    }
}
