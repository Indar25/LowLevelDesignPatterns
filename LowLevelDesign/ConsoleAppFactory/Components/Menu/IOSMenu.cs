using System;

namespace ConsoleAppFactory.Components.Menu
{
    public class IOSMenu : IMenu
    {
        public void ChangeMenu()
        {
            Console.WriteLine("Changing Menu for IOS");
        }
    }
}
