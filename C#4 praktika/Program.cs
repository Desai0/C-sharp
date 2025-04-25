class Program
{
    static void Main()
    {
        List<string> zveryo = new List<string> { "Дракон", "Единорог", "Грифон", "Минотавр", "Феникс" };
        int q = 0;
        string zver;
        while (q != 1)
        {
            Console.WriteLine("Выберите действие:" +
                "1. Добавление нового существа в список.\r\n2. Удаление существа по имени.\r\n3. Поиск всех существ, чьё название начинается с определённой буквы.\r\n4. Вывод всех существ в алфавитном порядке.\r\n");
            int vibor = int.Parse(Console.ReadLine());

            switch (vibor)
            {
                case 1:
                    Console.WriteLine("Введите имя нового существа");
                    zver = Console.ReadLine();
                    zveryo.Add(zver);
                    Console.WriteLine($"Зверь {zver} добавлен");

                    foreach (string word in zveryo)
                    {
                        Console.WriteLine(word);
                    }
                    break;
                case 2:
                    Console.WriteLine("Введите имя существа для удаления");
                    zver = Console.ReadLine();
                    bool delet = zveryo.Remove(zver);

                    if (delet == true)
                    {
                        Console.WriteLine($"Зверь {zver} удален");
                    } else
                    {
                        Console.WriteLine($"Зверь {zver} не существует");
                    }

                    foreach (string word in zveryo)
                    {
                        Console.WriteLine(word);
                    }
                    break;
                case 3:
                    Console.Write("\nВведите букву, с которой должны начинаться слова: ");
                    string input = Console.ReadLine();
                    char searchLetter = input[0];
                    List<string> matchingWords = zveryo.FindAll(word => word.StartsWith(searchLetter.ToString(), StringComparison.OrdinalIgnoreCase));

                    foreach (string word in matchingWords)
                    {
                        Console.WriteLine(word);
                    }
                    break;
                case 4:
                    foreach (string word in zveryo)
                    {
                        Console.WriteLine(word);
                    }

                    // Сортировка на месте
                    zveryo.Sort();

                    Console.WriteLine("\nОтсортированный список (после Sort()):");
                    foreach (string word in zveryo)
                    {
                        Console.WriteLine(word);
                    }
                    break;
            }

            Console.WriteLine("Хотите продолжить?\n" +
                "1 - нет");
            q = int.Parse(Console.ReadLine());

            Console.Clear();
        }
    
    
    }
}