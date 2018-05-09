using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternDesignExample.Products
{
    public class NullObjectFlight : IFlights
    {
        public void ExampleMethod()
        {
            throw new ApplicationException("Flight is null!1!");
        }
    }
}