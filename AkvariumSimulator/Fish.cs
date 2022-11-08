using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkvariumSimulator
{
    internal abstract class Fish
    {
        public string TypeOfFish { get; protected set; }
        public string Specie { get; set; }

        public double Health { set; get; } // fish regains health if the aquarium is clean, enough oxygen,and has enough food
        
        public bool IsAlive {protected set; get; }


        //public Food foodRequirement { get; set; }

        public int Strength { get; set; }

        
        protected double HungryMeter { get; set; } 
        public double Hunger { get; protected set; }
        // is true if hunger is at a certain level of hungrymeter
        public bool isHungry { get; set; }

        public double HungryPerTick { get; set; }

        public double DirtyPerTick { get; set; }

        public int OxygenRequirement { get; set; } // fish loses health if oxygen in aquarium is below this

        public double OxygenUsePerTick { get; set; } // the fish use of Oxygen from the aquarium
      

        public Aquarium AquariumHesIn { get; set; }

        


        public Fish( string specie, int strength, double hungryPerTick, double dirtyPerTick, int oxygenRequirement, double oxygenpertick  )
        {
            
           
            Specie = specie;
            Health = 100;
            IsAlive = true;
            HungryMeter = 100;
            Strength = strength;
            HungryPerTick = hungryPerTick;
            DirtyPerTick = dirtyPerTick;    
            OxygenRequirement = oxygenRequirement;
            OxygenUsePerTick = oxygenpertick;
        }

        public Fish()
        {
            IsAlive = true ;
            //HungryMeter = 100 ;
            isHungry = false;
            Hunger = 0 ;

        }

      public void CheckifAquariumHasEnoughO2()
        {
            if(AquariumHesIn.OxygenLevel< OxygenRequirement)
            {
                IsAlive = false;
            }
        }

       

       
 

        public void AddToHungryMeter() // #TODO: This is temporary
        {
            if(((Hunger += HungryPerTick) <= HungryMeter) ) { 
               
            Hunger += HungryPerTick;
            
            }
            ;
        }

        private void CheckIfHungry()
        {
            if(Hunger >= HungryMeter * 0.75 )
            {
                isHungry = true;
                Health -= 10;
              
                return;
            }
            if(Hunger >= HungryMeter / 2)
            {
                Health -= 5;
                isHungry = true;
                return;
            }
            
        }

        public virtual void Eat()
        {
             HungryMeter -= 50;
             AquariumHesIn.AddDirt(10);

        }

       

        public void CheckifIsAlive()
        {
            if(Health <= 0)
            {
                IsAlive = false;
            }
        }

        public void setAquariumFishisIn(Aquarium AquaHesIN)
        {
            AquariumHesIn = AquaHesIN;

        }
        


       

    }
}
