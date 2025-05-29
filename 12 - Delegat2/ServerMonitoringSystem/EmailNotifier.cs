using _12___Delegat2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12___Delegat2.ServerMonitoringSystem
{
    public class EmailNotifier : INotifier
    {
        private readonly string _adminEmail;

        public EmailNotifier(string adminEmail)
        {
            _adminEmail = adminEmail;
        }

        public void HandleServerDown(object sender, ServerDownEventArgs e)
        {
            Console.WriteLine($"Кому: {_adminEmail}");
            Console.WriteLine($"Тема: КРИТИЧЕСКОЕ ОПОВЕЩЕНИЕ: Сервер '{e.ServerName}' НЕДОСТУПЕН!");
            Console.WriteLine($"Время: {e.Timestamp:dd.MM.yyyy HH:mm:ss}");
            Console.WriteLine($"Причина: {e.ErrorMessage}");
        }
    }
}
