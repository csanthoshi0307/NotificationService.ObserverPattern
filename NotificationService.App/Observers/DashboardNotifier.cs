using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationService.App.Observers
{
    public class DashboardNotifier : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"[DASHBOARD] {message}");
        }
    }
}
