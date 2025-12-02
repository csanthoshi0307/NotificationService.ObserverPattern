using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationService.App.Observers
{
    public class SmsNotifier(string phoneNumber) : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"[SMS to {phoneNumber}] {message}");
        }
    }
}
