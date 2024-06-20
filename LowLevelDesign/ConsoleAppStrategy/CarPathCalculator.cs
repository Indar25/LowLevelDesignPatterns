using System;

namespace ConsoleAppStrategy
{
    internal class CarPathCalculator : IPathCalculatorStrategy
    {
        public void FindPath(string from, string to)
        {
            Console.WriteLine($"Car Path from {from} to {to}");
        }
    }
}
