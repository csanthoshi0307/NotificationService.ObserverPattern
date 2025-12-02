using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationService.App.Observers
{
    public class EmailNotifier(string emailAddress) : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"[EMAIL to {emailAddress}] {message}");
        }
    }
}
