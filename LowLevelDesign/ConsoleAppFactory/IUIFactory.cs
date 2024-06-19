using ConsoleAppFactory.Components.Button;
using ConsoleAppFactory.Components.Menu;

namespace ConsoleAppFactory
{
    public interface IUIFactory
    {
        IButton CreateButton();
        IMenu CreateMenu();
    }
}
