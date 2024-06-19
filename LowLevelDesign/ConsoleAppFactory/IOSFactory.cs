using ConsoleAppFactory.Components.Button;
using ConsoleAppFactory.Components.Menu;

namespace ConsoleAppFactory
{
    public class IOSFactory : IUIFactory
    {
        public IButton CreateButton()
        {
            return new IOSButton();
        }

        public IMenu CreateMenu()
        {
            return new IOSMenu();
        }
    }
}
