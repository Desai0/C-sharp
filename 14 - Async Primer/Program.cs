using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        MainAsync().GetAwaiter().GetResult();
    }

    static async Task MainAsync()
    {
        var db = new Database();

        var userTask = db.FindUserByNameAsync("Alice");
        Console.WriteLine("Ждем результат...");

        var user = await userTask;
        Console.WriteLine($"Пользователь найден: {user?.Name}");

        await db.ParallelQueriesAsync();
    }
}

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}

public class Database
{
    private readonly List<User> users = new List<User>
   {
       new User { Id = 1, Name = "Alice", Age = 25 },
       new User { Id = 2, Name = "Bob", Age = 30 },
       new User { Id = 3, Name = "Charlie", Age = 35 }
   };

    public async Task<User> FindUserByNameAsync(string name)
    {
        Console.WriteLine("Начинаем асинхронный поиск пользователя...");
        await Task.Delay(2000); // Имитация задержки
        return users.FirstOrDefault(u => u.Name == name);
    }

    public async Task ParallelQueriesAsync()
    {
        var task1 = FindUserByNameAsync("Alice");
        var task2 = FindUserByNameAsync("Bob");

        await Task.WhenAll(task1, task2);

        var user1 = task1.Result;
        var user2 = task2.Result;

        Console.WriteLine($"Найдены пользователи: {user1?.Name}, {user2?.Name}");
    }
}
