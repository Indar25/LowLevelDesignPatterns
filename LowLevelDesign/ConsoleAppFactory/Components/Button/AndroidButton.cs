using System;

namespace ConsoleAppFactory.Components.Button
{
    public class AndroidButton : IButton
    {
        public void ChangeSize()
        {
            Console.WriteLine("Changing button Size for Android");
        }
    }
}
