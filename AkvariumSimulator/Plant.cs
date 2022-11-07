using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkvariumSimulator
{
    internal class Plant
    {
        public double CreateOxygenPerTick { get; set; }
        public bool IsPoisonous { get; set; }

        public bool IsAlive { get; set; }

        public int Health { get; set; }
        public int DirtyMakesPerTick { get; set; }

        public Plant(double createOxygenPerTick, bool IsPoisonous)
        {
            Health = 100;
            IsAlive = true;
        }

        public void CheckIfIsAlive()
        {
            if(Health <= 0)
            {
                IsAlive = false;
            }
        }

        public void CreateDirtIfIsDead()
        {
            if(!IsAlive)
            {
                DirtyMakesPerTick = 2;
            }
            else
            {
                DirtyMakesPerTick = 0;
            }
            
        }
        

       
    }
}
