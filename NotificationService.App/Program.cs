// See https://aka.ms/new-console-template for more information
using NotificationService.App.Observers;
using NotificationService.App.Subject;

Console.WriteLine("=== Notification Service (Observer Pattern) - .NET 8 Demo ===\n");
// Create subject (publisher)
var eventManager = new OrderEventManager();

// Create observers
var email = new EmailNotifier("recipient@mail.com");
var sms = new SmsNotifier("+91-9876543210");
var dashboard = new DashboardNotifier();

//Subscribe observers
eventManager.Subscribe(email);
eventManager.Subscribe(sms);
eventManager.Subscribe(dashboard);

Console.WriteLine("\n>>> Simulating order events...\n");

// Trigger events
eventManager.NewOrderPlaced("ORD-2001");
eventManager.OrderDispatched("ORD-2001");

Console.WriteLine("\n>>> Unsubscribing SMS...\n");
eventManager.Unsubscribe(sms);

eventManager.OrderCancelled("ORD-2001");

Console.WriteLine("\nDone.");