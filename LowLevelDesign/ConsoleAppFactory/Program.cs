using ConsoleAppFactory.Components.Button;
using System;

namespace ConsoleAppFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Flutter flutter =new Flutter();
            IButton button = flutter.CreateUIFactory(SupportedPlateform.IOS).CreateButton();
            button.ChangeSize();
            Console.WriteLine("Hello World!");
        }
    }
}
