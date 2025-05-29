using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12___Delegat2.ServerMonitoringSystem
{
    public class ServerDownEventArgs : EventArgs
    {
        public string ServerName { get; }
        public DateTime Timestamp { get; }
        public string ErrorMessage { get; }

        public ServerDownEventArgs(string serverName, DateTime timestamp, string errorMessage)
        {
            ServerName = serverName;
            Timestamp = timestamp;
            ErrorMessage = errorMessage;
        }
    }
}
