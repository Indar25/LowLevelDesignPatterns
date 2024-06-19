using ConsoleAppFactory.Components.Button;
using ConsoleAppFactory.Components.Menu;
using System;

namespace ConsoleAppFactory
{
    public class UIFactoryCreator
    {
        public static IUIFactory CreateFactory(SupportedPlateform plateform)
        {
            //if (plateform.Equals(SupportedPlateform.Android))
            //    return new AndroidFactory();
            //else
            //    return new IOSFactory();

            return plateform switch
            {
                SupportedPlateform.Android => new AndroidFactory(),
                SupportedPlateform.IOS => new IOSFactory(),
                _ => throw new ArgumentException("Unsupported plateform")
            };
        }
    }
}
