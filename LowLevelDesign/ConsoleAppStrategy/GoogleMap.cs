namespace ConsoleAppStrategy
{
    public class GoogleMap
    {
        public void FindPath(string from, string to, TransportModes mode)
        { 
            IPathCalculatorStrategy strategy = PathCalculatorFactory.getPathCalculatorForMode(mode);
            strategy.FindPath(from, to);
        }
    }
}
