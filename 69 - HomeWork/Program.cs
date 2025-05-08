using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Int16 q = 0;
        while (q == 0)
        {
            Console.WriteLine("Выберите действие:\n" +
            "1. Определить тип осадков\r\n2. Определить комфортность температуры\r\n3. Выход");

            UIntPtr chose = UIntPtr.Parse(Console.ReadLine());

            switch (chose)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Введите уровень осадков (в мм)");
                    // double level = double.Parse(Console.ReadLine()); Неверно работает, пишу 11, а входит он в диапазон 0.1-2.5
                    double level = Convert.ToDouble(Console.ReadLine());
                    if (level < 0)
                    {
                        Console.WriteLine("Ошибка: уровень осадков не может быть отрицательным");
                    }
                    else if (level < 0.1)
                    {
                        Console.WriteLine("Нет осадков");
                    }
                    else if (level >= 0.1 && level <= 2.5)
                    {
                        Console.WriteLine("Небольшой дождь");
                    }
                    else if (level >= 2.6 && level <= 17)
                    {
                        Console.WriteLine("Умеренный дождь");
                    }
                    else
                    {
                        Console.WriteLine("Сильный дождь");
                    }
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Введите температуру (в градусах Цельсия)");
                    double temperature = double.Parse(Console.ReadLine());
                    string status = (temperature > 25) ? "Жарко" : (temperature < 10) ? "Холодно" : "Комфортно";
                    Console.WriteLine(status);
                    break;
                case 3:
                    Console.Clear();
                    q = 69;
                    break;
            }
        }
    }
}
