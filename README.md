# Notification Service – Observer Pattern (C# .NET 8)

A simple demonstration of the Observer Design Pattern implemented using the latest C# 12 and .NET 8 features.

##  Features
- Uses Observer Pattern (Publisher–Subscriber)
- Modern C# 12 syntax:
  - Primary constructors
  - File-scoped namespaces
  - Collection expressions
- Extensible notification system: Email, SMS, Dashboard

##  Project Structure
NotificationService.App/
??? Observers/
? ??? IObserver.cs
? ??? EmailNotifier.cs
? ??? SmsNotifier.cs
? ??? DashboardNotifier.cs
??? Subject/
? ??? OrderEventManager.cs
??? Program.cs


##  Run the project

 /// bash
cd NotificationService.App
dotnet run


[SYSTEM] Subscribed: EmailNotifier
[SYSTEM] Subscribed: SmsNotifier
[SYSTEM] Subscribed: DashboardNotifier

[EMAIL] New order placed...
[SMS] New order placed...
[DASHBOARD] New order placed...
