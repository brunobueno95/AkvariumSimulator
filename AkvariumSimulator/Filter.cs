using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkvariumSimulator
{
    internal class Filter
    {
        // public double Price { get; set; } #TODO: create a stroe for buying stuff
        public double CreatesOxygenPerTick { get; set; }
        public double CleansPerTick { get; set; }

        public Filter( double createsOxygenPerTick, double cleansPerTick)
        {
            CreatesOxygenPerTick = createsOxygenPerTick;
            CleansPerTick= cleansPerTick;
        }

    }
}
