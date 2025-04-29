using System.Xml.Linq;
using System.Collections.Generic;
using System;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }
    public int Pages { get; set; }
    public string Genre { get; set; }

    public Book(string title, string author, int year, int pages, string genre)
    {
        Title = title;
        Author = author;
        Year = year;
        Pages = pages;
        Genre = genre;
    }
}

class Program
{
    static void Main()
    {
        var books = new List<Book>()
        {
            new Book("Война и мир", "Лев Толстой", 1869, 1225, "Исторический роман"),
            new Book("Мастер и Маргарита", "Михаил Булгаков", 1967, 480, "Роман"),
            new Book("1984", "Джордж Оруэлл", 1949, 328, "Дистопия"),
            new Book("Гордость и предубеждение", "Лев Толстой", 1813, 432, "Роман"),
            new Book("Убить пересмешника", "Харпер Ли", 1960, 324, "Художественная литература"),
            new Book("Гарри Поттер и философский камень", "Джоан Роулинг", 1997, 320, "Фэнтези"),
            new Book("Дюна", "Фрэнк Герберт", 1965, 658, "Научная фантастика"),
            new Book("Преступление и наказание", "Федор Достоевский", 1866, 528, "Философский роман"),
            new Book("Маленький принц", "Антуан де Сент-Экзюпери", 1943, 96, "Повесть-сказка"),
            new Book("Маленький принц", "Антуан де Сент-Экзюпери", 1943, 96, "Повесть-сказка"),
            new Book("Хоббит, или Туда и обратно", "Дж. Р. Р. Толкин", 1937, 310, "Фэнтези")
        };

        int q = 0;
        while (q == 0)
        {
            Console.WriteLine("Выберите действие: \n" +
                "1 - Фильтрация (Найти все книги, опубликованные после определённого года)\n" +
                "2 - Сортировка (Отсортировать книги по количеству страниц (по возрастанию) и вывести их названия)\n" +
                "3 - Выборка данных (Получить список названий и авторов книг, принадлежащих к определённому жанру)\n" +
                "4 - Агрегатные функции (Count/Sum/Min/Max/Average)\n" +
                "5 - Группировка данных (Сгруппировать книги по жанру и вывести количество книг в каждом жанре)\n" +
                "6 - Комбинирование нескольких операций (Найти все книги, написанные автором \"Имя Автора\" (выбрать одно из своего списка), отсортировать их по году издания и вывести только названия)\n" +
                "7 - Разбиение данных Take - (Выбрать первые 3 книги из списка)\n" +
                "8 - Разбиение данных Skip - (Выбрать последние 3 книги из списка)\n" +
                "9 - Работа с множествами - (Удалить дубликаты из коллекции, если они есть)\n" +
                "10 - Работа с множествами - (Найти уникальные жанры книг)\n" +
                "11 - Выход\n");

            int chose = int.Parse(Console.ReadLine());

            switch (chose)
            {
                case (1):
                    Console.Clear();
                    Console.WriteLine("Введите год: ");
                    int god = int.Parse(Console.ReadLine());
                    var filtredBooks = books
                        .Where(x => x.Year > god);

                    Console.WriteLine("Отфильтровано!");
                    foreach (var book in filtredBooks)
                    {
                        Console.WriteLine($"Книга: {book.Title} была написана в {book.Year}");
                    }

                    Console.WriteLine("\n");
                    break;

                case (2):
                    Console.Clear();
                    var sortedBooks = books
                        .OrderBy(x => x.Pages);

                    Console.WriteLine("Отфильтровано!");
                    foreach (var book in sortedBooks)
                    {
                        Console.WriteLine($"Книга: {book.Title} имеет {book.Pages} страниц");
                    }

                    Console.WriteLine("\n");
                    break;

                case (3):
                    Console.Clear();
                    Console.WriteLine($"Впишите жанр:\n" +
                        $"Исторический роман\n" +
                        $"Роман\n" +
                        $"Дистопия\n" +
                        $"Художественная литература\n" +
                        $"Фэнтези\n" +
                        $"Научная фантастика\n" +
                        $"Филосовский Роман\n" +
                        $"Повесть-сказка\n");
                    string zhanr = Console.ReadLine();

                    var vibrannieBooks = books
                        .Where(x => x.Genre == zhanr);
                    foreach (var book in vibrannieBooks)
                    {
                        Console.WriteLine($"Книга: {book.Title}, жанр: {book.Genre}, автор: {book.Author}");
                    }

                    Console.WriteLine("\n");
                    break;

                case (4):
                    Console.Clear();
                    Console.WriteLine("Выберите функцию: \n" +
                        "1 - Count: Найти количество книг \n" +
                        "2 - Sum: Найти количество страниц во всех книгах\n" +
                        "3 - Min: Найти минимальное количество страниц в книге\n" +
                        "4 - Max: Найти максимальное количество страниц в книге\n" +
                        "5 - Average: Найти среднее количество страниц среди всех книг\n");

                    int chose2 = int.Parse(Console.ReadLine());

                    switch (chose2)
                    {
                        case (1):
                            int i = 0;
                            foreach (var book in books)
                            {
                                i++;
                            }
                            Console.WriteLine($"Кол-во книг: {i}");

                            Console.WriteLine("\n");
                            break;
                        case (2):
                            i = 0;
                            foreach (var book in books)
                            {
                                i += book.Pages;
                            }
                            Console.WriteLine($"Кол-во страниц: {i}");

                            Console.WriteLine("\n");
                            break;
                        case (3):
                            i = int.MaxValue;
                            foreach (var book in books)
                            {
                                if (i > book.Pages)
                                {
                                    i = book.Pages;
                                }
                            }
                            Console.WriteLine($"Минимальное кол-во страниц: {i}");

                            Console.WriteLine("\n");
                            break;
                        case (4):
                            i = int.MinValue;
                            foreach (var book in books)
                            {
                                if (i < book.Pages)
                                {
                                    i = book.Pages;
                                }
                            }
                            Console.WriteLine($"Максимальное кол-во страниц: {i}");

                            Console.WriteLine("\n");
                            break;
                        case (5):
                            i = 0;
                            int j = 0;
                            foreach (var book in books)
                            {
                                j++;
                                i += book.Pages;
                            }
                            i = i / j;
                            Console.WriteLine($"Среднее кол-во страниц (с округлением): {i}");

                            Console.WriteLine("\n");
                            break;
                    }

                    Console.WriteLine("\n");
                    break;
                case (5):
                    Console.Clear();
                    var groupedBooks = books
                        .GroupBy(x => x.Genre);

                    int g = 0;
                    foreach (var group in groupedBooks)
                    {
                        Console.WriteLine($"Жанр: {group.Key}"); //как словарь, ключ - значение, сначала берем кей из group, потом group распоковываем до person
                        foreach (var book in group)
                        {
                            g++;
                        }
                        Console.WriteLine($"Кол-во книг: {g}");
                        g = 0;
                    }

                    Console.WriteLine("\n");
                    break;
                case (6):
                    Console.Clear();
                    Console.WriteLine("Автор - Лев Толстой");

                    var filteredBooks = books
                        .Where(x => x.Author == "Лев Толстой")
                        .OrderBy(x => x.Year);

                    foreach (var book in filteredBooks)
                    {
                        Console.Write($"{book.Title}; ");
                    }

                    Console.WriteLine("\n");
                    break;
                case (7):
                    Console.Clear();

                    var takedBooks = books
                        .Take(3);
                    foreach (var book in takedBooks)
                    {
                        Console.Write($"{book.Title}; ");
                    }

                    Console.WriteLine("\n");
                    break;
                case (8):
                    Console.Clear();

                    var skippedBooks = books
                        .Skip(8);
                    foreach (var book in skippedBooks)
                    {
                        Console.Write($"{book.Title}; ");
                    }

                    Console.WriteLine("\n");
                    break;
                case (9):
                    Console.Clear();

                    var distinct = books.Distinct();
                    foreach (var book in distinct)
                    {
                        Console.Write($"{book.Title}; ");
                    }

                    Console.WriteLine("\n");
                    break;
                case (10):
                    Console.Clear();

                    var except = books.Except(books);
                    foreach (var book in except)
                    {
                        Console.Write($"{book.Genre}; "); // не работает
                    }

                    Console.WriteLine("\n");
                    break;
                case (11):
                    Console.Clear();
                    q++;

                    Console.WriteLine("\n"); // не работает
                    break;
            }
                











        }
    }
}