using System;

namespace ConsoleAppObserver
{
    internal class Program
    {
        //Problem Statement
        //When some event happens, we might need to do a lot of things. 
        //Every time we need to add/ remove the actions, 
        //we'll have to update the code & compile it again.

        static void Main(string[] args)
        {
            AmazonOrderPlace orderPlace = new AmazonOrderPlace();

            NotificationService notificationService = new NotificationService();
            InventoryManagementService inventoryManagementService = new InventoryManagementService();
            EmailService emailService = new EmailService();

            orderPlace.RegisterOrderSubscription(notificationService);
            orderPlace.RegisterOrderSubscription(inventoryManagementService);
            orderPlace.RegisterOrderSubscription(emailService);

            orderPlace.OrderPlaced();

            orderPlace.UnregisterOrderSubscription(notificationService);
            orderPlace.OrderPlaced();
            Console.ReadKey();
        }
    }
}
