using System;

namespace CarbonFootprintLibrary   
{
    public class Building : ICarbonFootprintLibrary
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

        public void CalculateCarbonFootprint()
        {
            //134 per sqft
            Console.WriteLine($"Carbon footprint for a building of {SquareFeet} square feet is : {SquareFeet * 134}");
        }
    }
}

