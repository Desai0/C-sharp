using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12___Delegat2.ServerMonitoringSystem
{
    public delegate void ServerDownEventHandler(object sender, ServerDownEventArgs e);
    public class ServerMonitor
    {
        public string ServerName { get; }
        private static readonly Random _random = new Random(); //для эмуляции проблем ^-^

        public event ServerDownEventHandler? ServerDown;

        public ServerMonitor(string serverName)
        {
            ServerName = serverName;
        }

        public void CheckServerStatus()
        {
            Console.WriteLine($"\n[{DateTime.Now:HH:mm:ss}] Проверка состояния сервера '{ServerName}'...");

            if (_random.Next(1, 101) <= 30)
            {
                string errorMessage = GetRandomErrorMessage();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"ОШИБКА! Сервер '{ServerName}' недоступен. Причина: {errorMessage}");
                Console.ResetColor();
                // Генерируем событие
                OnServerDown(new ServerDownEventArgs(ServerName, DateTime.Now, errorMessage));
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Сервер '{ServerName}' работает нормально.");
                Console.ResetColor();
            }
        }

        private string GetRandomErrorMessage()
        {
            string[] messages = {
                "Высокая загрузка ЦП",
                "Недостаточно памяти",
                "Сетевое подключение потеряно",
                "Ошибка дисковой подсистемы",
                "Критическое обновление не установлено"
            };
            return messages[_random.Next(messages.Length)];
        }


        protected virtual void OnServerDown(ServerDownEventArgs e)
        {
            ServerDown?.Invoke(this, e);
        }
    }
}
