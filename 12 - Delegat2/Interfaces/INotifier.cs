using _12___Delegat2.ServerMonitoringSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12___Delegat2.Interfaces
{
    public interface INotifier
    {
        void HandleServerDown(object sender, ServerDownEventArgs e);
    }
}
