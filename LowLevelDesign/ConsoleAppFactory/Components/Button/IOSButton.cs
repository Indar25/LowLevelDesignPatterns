using System;

namespace ConsoleAppFactory.Components.Button
{
    public class IOSButton : IButton
    {
        public void ChangeSize()
        {
            Console.WriteLine("Changing button Size for IOS");
        }
    }
}
