class Program
{
    static void Main()
    {
        Stack<string> stack = new Stack<string>();

        stack.Push("Книга книжна");
        stack.Push("Как стать успешным плебеем");
        stack.Push("Богатый отчим, бедный аким");

        Int16 q = 0;
        string? book;
        while (q == 0)
        {
            Console.WriteLine("Выберите действие\n" +
                "1. Положить на верх стопки.\r\n2. Убрать книгу сверху.\r\n3. Просмотреть название книги сверху без её удаления.\r\n4. Вывести текущую стопку книг.\r\n5. Выход");
            Int16 chose = Int16.Parse(Console.ReadLine());

            switch (chose)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Введите название книги: ");
                    book = Console.ReadLine();
                    stack.Push(book);
                    break;
                case 2:
                    Console.Clear();
                    if (!stack.TryPop(out book))
                    {
                        Console.WriteLine("Ошибка, стек пуст");
                    }
                    break;
                case 3:
                    Console.Clear();
                    if (!stack.TryPeek(out book))
                    {
                        Console.WriteLine("Ошибка, стек пуст");
                    }
                    else
                    {
                        Console.WriteLine($"Книга сверху: {book}");
                    }
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Книги в стопке: ");
                    foreach (var item in stack)
                    {
                        Console.WriteLine(item);
                    }
                    break;
                case 5:
                    Console.Clear();
                    q++;
                    break;
            }
        }
    }
}