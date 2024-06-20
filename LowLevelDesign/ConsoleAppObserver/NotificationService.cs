using System;

namespace ConsoleAppObserver
{
    public class NotificationService : IOrderPlaceSubscriber
    {
        public void OnOrderPlaced()
        {
            Console.WriteLine("Order place Notification Service");
        }
        public void OnOrderPlaced(object sender, EventArgs e)
        {
            Console.WriteLine("Order place Notification Service");
        }
    }
}
