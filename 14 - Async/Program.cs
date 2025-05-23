// Асинхронное программирование - это подход к написанию кода при котором
// выполнение некоторых операций выноситься из основного потока выполнения программы

using System;
using System.Linq;
using System.Threading.Tasks;

// Синхронное выполнения - операция выполняется после завершения предыдущей
// Асинхронное - некоторые операции выполняются паралельно с основным потоком

// Когда используется:
//  Операции ввода вывода
//  Долгие вычесления
//  Улучшения отзывчивости приложения
class Program
{
    static void Main()
    {
        Console.WriteLine(0);
        Method();
        Method2();
        Console.WriteLine(0);
    }

    static void Method()
    {
        Task task = Task.Delay(2000); // асинхронная операция которая не возвращает значение
        Task<int> task2 = Task.FromResult(2000); // асинхронная операция, возвращающая знач
    } // используется как тип возвр знач у асинхронных методов

    static async Task Method2()
    {
        Console.WriteLine(1);
        await Task.Delay(2000); // тут задержка, в мейне продолжится
        Console.WriteLine(1);
    }


    public async Task ExecutePT()
    {
        var task10 = Task.Delay(1000);
        var task11 = Task.Delay(2000);

        await Task.WhenAll(task10, task11);
        Console.WriteLine("Обе выполнены");
    }

    public async Task ExecuteTaskWithAny()
    {
        var task10 = Task.Delay(1000);
        var task11 = Task.Delay(3000);

        var completedTask = await Task.WhenAny(task10, task11);
    }
}