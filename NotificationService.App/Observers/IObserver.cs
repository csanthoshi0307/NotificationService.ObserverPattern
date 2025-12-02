using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationService.App.Observers
{
    public interface IObserver
    {
        void Update(string message);
    }
}
