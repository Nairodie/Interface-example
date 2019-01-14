using System;

namespace CarbonFootprintLibrary
{
    public class Bicycle : ICarbonFootprintLibrary
    {
        public void CalculateCarbonFootprint()
        {
            Console.WriteLine($"A bicycle has no Carbon Footprint");
        }
    }
}
