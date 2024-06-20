using System;

namespace ConsoleAppStrategy
{
    internal class Program
    {
        //STRATEGY DESIGN PATTERN
        //Rather than implementing the behaviors in a methods, implement them in a separate class. 
        //For every way to do something, create its own class.

        static void Main(string[] args)
        {
            GoogleMap map = new GoogleMap();
            map.FindPath("noida", "delhi", TransportModes.Bike);
            Console.ReadKey();
        }
    }
}
