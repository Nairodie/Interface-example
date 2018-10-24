using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarbonFootprint
{
    class Bicycle : ICarbonFootprint
    {
        public void CalcutateCarbonFootprint()
        {
            Console.WriteLine("A bicycle has no Carbon Footprint");
        }
    }
}
