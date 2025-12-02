using NotificationService.App.Observers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationService.App.Subject
{
    public class OrderEventManager
    {
        private readonly List<IObserver> _observers = [];

        public void Subscribe(IObserver observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
                Console.WriteLine($"[SYSTEM] Subscribed: {observer.GetType().Name}");
            }
        }

        public void Unsubscribe(IObserver observer)
        {
            if (_observers.Remove(observer))
            {
                Console.WriteLine($"[SYSTEM] Unsubscribed: {observer.GetType().Name}");
            }
        }

        private void Notify(string message)
        {
            foreach (var observer in _observers)
            {
                observer.Update(message);
            }
        }

        // Business Events
        public void NewOrderPlaced(string orderId)
            => Notify($"New order placed: {orderId}");

        public void OrderDispatched(string orderId)
            => Notify($"Order dispatched: {orderId}");

        public void OrderCancelled(string orderId)
            => Notify($"Order cancelled: {orderId}");
    }
}
