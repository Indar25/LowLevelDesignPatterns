using System;

namespace ConsoleAppObserver
{
    public class EmailService : IOrderPlaceSubscriber
    {
        public void OnOrderPlaced()
        {
            Console.WriteLine("Order Place Email Service");
        }
        public void OnOrderPlaced(object sender, EventArgs e)
        {
            Console.WriteLine("Order Place Email Service");
        }
    }
}
