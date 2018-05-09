using FactoryPatternDesignExample.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternDesignExample
{
    public class ProductFactory
    {
        public IFlights Create(
            FlightType flightType)
        {
            IFlights flight = null;

            switch (flightType)
            {
                case FlightType.Cyclic:
                    {
                        flight = new CyclicFlight();
                    }
                    break;
                case FlightType.Normal:
                    {
                        flight = new NormalFlight();
                    }
                    break;
                default:
                    return new NullObjectFlight();
            }

            return flight;
        }
    }
}