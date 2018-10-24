using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarbonFootprint
{
    class Building : ICarbonFootprint
    {
        public Building (int squareFeet)
        {
            SquareFeet = squareFeet;
        }

        private int _sqft;
        public int SquareFeet
        {
            get { return _sqft; }
            set
            {
                if (value >= 0)
                {
                    _sqft = value;
                }
            }
        }

        public void CalcutateCarbonFootprint()
        {
            //134 per sqft
            Console.WriteLine("Carbon footprint for a building of {0} square feet is : {1}",
                SquareFeet, SquareFeet * 134);
        }
    }
}
