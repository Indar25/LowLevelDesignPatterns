using System;

namespace ConsoleAppFactory
{
    public class Flutter
    {
        public void setTheme() {
            Console.WriteLine("Setting Theme");
        }
        public void setRefreshRate()
        {
            Console.WriteLine("Setting RefreshRate");
        }
        public IUIFactory CreateUIFactory(SupportedPlateform plateform) {
            return UIFactoryCreator.CreateFactory(plateform);
        }
    }
}
