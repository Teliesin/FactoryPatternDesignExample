using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternDesignExample
{
    public class CyclicFlight : IFlights
    {
        public void ExampleMethod()
        {
            Console.WriteLine("Lot cykliczny");
        }
    }
}