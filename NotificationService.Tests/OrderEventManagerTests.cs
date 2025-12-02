using NotificationService.App.Observers;
using NotificationService.App.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationService.Tests
{
    public class TestObserver : IObserver
    {
        public string LastMessage { get; private set; } = "";

        public void Update(string message)
        {
            LastMessage = message;
        }
    }
    public class OrderEventManagerTests
    {
        [Fact]
        public void Observer_ShouldReceive_Notification()
        {
            // Arrange
            var manager = new OrderEventManager();
            var observer = new TestObserver();
            manager.Subscribe(observer);

            // Act
            manager.NewOrderPlaced("ORD-9001");

            // Assert
            Assert.Equal("New order placed: ORD-9001", observer.LastMessage);
        }

        [Fact]
        public void UnsubscribedObserver_ShouldNotReceive_Notification()
        {
            var manager = new OrderEventManager();
            var observer = new TestObserver();

            manager.Subscribe(observer);
            manager.Unsubscribe(observer);

            manager.NewOrderPlaced("ORD-9999");

            Assert.NotEqual("New order placed: ORD-9999", observer.LastMessage);
        }
    }
}
