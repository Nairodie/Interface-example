using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarbonFootprint
{
    class Car : ICarbonFootprint
    {
        public Car (double gallons)
        {
            Gallons = gallons;
        }

        //amount of gallons
        private double _gallons;

        public double Gallons
        {
            get { return _gallons; }
            set
            {
                if (value >= 0)
                {
                    _gallons = value;
                }
            }
        }

        public void CalcutateCarbonFootprint()
        {
            //20  co2 = 1 gallon
            Console.WriteLine("The carbon footprint for a car that has used {0} gallons is: {1}",
                Gallons, Gallons * 20);
               
        }
    }
}
