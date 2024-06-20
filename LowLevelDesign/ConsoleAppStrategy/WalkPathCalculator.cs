using System;

namespace ConsoleAppStrategy
{
    internal class WalkPathCalculator : IPathCalculatorStrategy
    {
        public void FindPath(string from, string to)
        {
            Console.WriteLine($"Walk Path from {from} to {to}");
        }
    }
}
