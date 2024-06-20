using System;

namespace ConsoleAppObserver
{
    public interface IOrderPlaceSubscriber
    {
        void OnOrderPlaced();
        void OnOrderPlaced(object sender, EventArgs e);
    }
}
