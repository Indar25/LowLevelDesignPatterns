using System;
using System.Collections.Generic;

namespace ConsoleAppObserver
{
    public class AmazonOrderPlace
    {
        private readonly List<IOrderPlaceSubscriber> _subscriptions = new List<IOrderPlaceSubscriber>();
        public event EventHandler OrderPlacedEvent;
        public void RegisterOrderSubscription(IOrderPlaceSubscriber subscriber)
        {
            //if (!_subscriptions.Contains(subscriber))
            //{
            //    _subscriptions.Add(subscriber);
            //}
            OrderPlacedEvent += subscriber.OnOrderPlaced;
        }
        public void UnregisterOrderSubscription(IOrderPlaceSubscriber subscriber)
        {

            //if (_subscriptions.Contains(subscriber))
            //{
            //    _subscriptions.Remove(subscriber);
            //}
            //else
            //{
            //    Console.WriteLine("Subscriber not found.");
            //}
            OrderPlacedEvent -= subscriber.OnOrderPlaced;
        }
        public void OrderPlaced()
        {
            //foreach (var subscriber in _subscriptions)
            //{
            //    subscriber.OnOrderPlace();
            //}
            OrderPlacedEvent?.Invoke(this, EventArgs.Empty);
        }
    }
}
