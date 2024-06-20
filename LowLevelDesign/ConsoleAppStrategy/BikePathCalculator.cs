using System;

namespace ConsoleAppStrategy
{
    internal class BikePathCalculator : IPathCalculatorStrategy
    {
        public void FindPath(string from, string to)
        {
            Console.WriteLine($"Bike Path from {from} to {to}");
        }
    }
}
