using ConsoleAppFactory.Components.Button;
using ConsoleAppFactory.Components.Menu;

namespace ConsoleAppFactory
{
    public class AndroidFactory : IUIFactory
    {
        public IButton CreateButton()
        {
            return new AndroidButton();
        }

        public IMenu CreateMenu()
        {
            return new AndroidMenu();
        }
    }
}
