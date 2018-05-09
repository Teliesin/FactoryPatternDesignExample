using System;

namespace FactoryPatternDesignExample
{
    class Program
    {
        static void Main(string[] args)
        {
            FlightType flightType = FlightType.TypAdamowy;

            //=================================

            ProductFactory factory = new ProductFactory();

            IFlights flight = factory.Create(flightType);

            flight.ExampleMethod();

            Console.ReadKey();
        }
    }
}
