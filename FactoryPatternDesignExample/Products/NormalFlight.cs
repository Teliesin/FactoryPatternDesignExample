using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternDesignExample
{
    public class NormalFlight : IFlights
    {
        public void ExampleMethod()
        {
            Console.WriteLine("Lot normalny");
        }
    }
}