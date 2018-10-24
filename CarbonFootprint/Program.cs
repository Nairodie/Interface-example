using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarbonFootprint
{
    class Program
    {
        static void Main()
        {
            //polymorphism @ work part 1            
            ICarbonFootprint[] list = new ICarbonFootprint[3];

            list[0] = new Bicycle();
            list[1] = new Building(2500);
            list[2] = new Car(15);

            //invoked on each of the derived classes, not the base class.
            //polymorphism @ work part 2
            foreach (var element in list)
            {
                element.CalcutateCarbonFootprint();
            }
        }
    }
}

