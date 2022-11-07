using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkvariumSimulator
{
    internal abstract class Fish
    {
        public string Specie { get; set; }

        public double Health { set; get; } // fish regains health if the aquarium is clean, enough oxygen,and has enough food
        
        public bool IsAlive {protected set; get; }

        public bool isHungry { get; set; }

        //public Food foodRequirement { get; set; }

        public int Strength { get; set; }

        private string acceptedFoodType { get; set; } // "vegetarian"

        protected double HungryMeter { get; set; }

        public double HungryPerTick { get; set; }

        public double DirtyPerTick { get; set; }

        public int OxygenRequirement { get; set; } // fish loses health if oxygen in aquarium is below this

        public double OxygenUsePerTick { get; set; } // the fish use of Oxygen from the aquarium

        public Fish( string specie, string _acceptedFoodType)
        {
            AcceptedFoodType = _acceptedFoodType;
            Specie = specie;
            Health = 100;
            IsAlive = true;
        }

        public string AcceptedFoodType
        {
            get { return acceptedFoodType; }
            set
            {
                if(value == "vegetarian" || value == "carni")
                {
                    value = acceptedFoodType;
                }
                else
                {
                    value = "both";
                }
            }
        }



        private double DirtyMeter{get ; set; } 

        void hungryFunc() // #TODO: This is temporary
        {
            HungryMeter+= HungryPerTick;
        }

        // if hungry is equal to or over a certain level, then the fish will eat (hungry bool will be true)

    }
}
