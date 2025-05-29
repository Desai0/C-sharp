using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _12___Delegat2.Interfaces;

namespace _12___Delegat2.ServerMonitoringSystem
{
    public class SmsNotifier : INotifier
    {
        private readonly string _adminPhoneNumber;

        public SmsNotifier(string adminPhoneNumber)
        {
            _adminPhoneNumber = adminPhoneNumber;
        }

        // Реализация метода из интерфейса INotifier
        public void HandleServerDown(object sender, ServerDownEventArgs e)
        {
            Console.WriteLine("--- SMS Уведомление (через INotifier) ---");
            Console.WriteLine($"Номер: {_adminPhoneNumber}");
            Console.WriteLine($"ТРЕВОГА! Сервер '{e.ServerName}' упал в {e.Timestamp:HH:mm}. Причина: {e.ErrorMessage}.");
            Console.WriteLine("----------------------------------------");
        }
    }
}
