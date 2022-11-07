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
       public double DirtyMeter { get; protected set; }

        


        public Fish( string specie, string _acceptedFoodType, int strength, double hungryPerTick, double dirtyPerTick, int oxygenRequirement, double oxygenpertick  )
        {
            AcceptedFoodType = _acceptedFoodType;
            Specie = specie;
            Health = 100;
            IsAlive = true;
            HungryMeter = 0;
            Strength = strength;
            HungryPerTick = hungryPerTick;
            DirtyPerTick = dirtyPerTick;    
            OxygenRequirement = oxygenRequirement;
            OxygenUsePerTick = oxygenpertick;
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
 

        public void CalculateHungry() // #TODO: This is temporary
        {
            HungryMeter+= HungryPerTick;
        }

        public void Eat()
        {
            HungryMeter -= 50;
           DirtyMeter += 10;

        }

        public void CheckIfTheyRHungry()
        {
            if(HungryMeter == 100)
            {
                isHungry = true;
            }

        }
        // if hungry is equal to or over a certain level, then the fish will eat (hungry bool will be true)

    }
}
