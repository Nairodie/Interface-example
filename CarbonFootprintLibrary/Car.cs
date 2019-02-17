using System;

namespace CarbonFootprintLibrary
{
    public class Car : ICarbonFootprintLibrary
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

        public void CalculateCarbonFootprint()
        {
            //20  co2 = 1 gallon
            Console.WriteLine($"The carbon footprint for a car that has used {Gallons} is: {Gallons * 20}");
        }
    }
}
