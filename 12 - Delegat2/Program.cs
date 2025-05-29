// Program.cs
using System;
using System.Threading;
using _12___Delegat2.Interfaces;
using _12___Delegat2.ServerMonitoringSystem;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Система Мониторинга Серверов запущена.");

        ServerMonitor webServerMonitor = new ServerMonitor("WebServer-01");
        ServerMonitor dbServerMonitor = new ServerMonitor("DatabaseServer-Alpha");

        // Создаем уведомителей. Теперь мы можем ссылаться на них через интерфейс.
        INotifier emailAdmin = new EmailNotifier("admin@example.com");
        INotifier smsOpsTeam = new SmsNotifier("+1234567890");
        INotifier secondaryEmailAdmin = new EmailNotifier("support_level2@example.com");

        // Подписываем методы HandleServerDown на событие ServerDown
        webServerMonitor.ServerDown += emailAdmin.HandleServerDown;
        webServerMonitor.ServerDown += smsOpsTeam.HandleServerDown;

        dbServerMonitor.ServerDown += emailAdmin.HandleServerDown;
        dbServerMonitor.ServerDown += secondaryEmailAdmin.HandleServerDown;


        Console.WriteLine("\n--- Начало мониторинга ---");
        for (int i = 0; i < 5; i++)
        {
            webServerMonitor.CheckServerStatus();
            dbServerMonitor.CheckServerStatus();
            Console.WriteLine("---------------------------------------------------");
            Thread.Sleep(2000);
        }

        Console.WriteLine("\nОтписываем SMS уведомления для WebServer-01 и проверяем снова...");
        webServerMonitor.ServerDown -= smsOpsTeam.HandleServerDown; // Отписка работает так же

        webServerMonitor.CheckServerStatus();

        Console.WriteLine("\n--- Мониторинг завершен ---");
        Console.ReadKey();
    }
}