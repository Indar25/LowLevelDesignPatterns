using System;

namespace ConsoleAppStrategy
{
    public class PathCalculatorFactory
    {
        public static IPathCalculatorStrategy getPathCalculatorForMode(TransportModes mode)
        {
            return mode switch
            {
                TransportModes.Bike => new BikePathCalculator(),
                TransportModes.Car => new CarPathCalculator(),
                TransportModes.Walk => new WalkPathCalculator(),
                _ => throw new ArgumentException("Unsupported mode")
            };
        }
    }
}
