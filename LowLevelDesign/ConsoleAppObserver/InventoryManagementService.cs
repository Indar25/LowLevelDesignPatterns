using System;

namespace ConsoleAppObserver
{
    public class InventoryManagementService : IOrderPlaceSubscriber
    {
        public void OnOrderPlaced()
        {
            Console.WriteLine("Order Place Inventory Management Service");
        }
        public void OnOrderPlaced(object sender, EventArgs e)
        {
            Console.WriteLine("Order Place Inventory Management Service");
        }
    }
}
