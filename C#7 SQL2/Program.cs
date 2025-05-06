using Microsoft.EntityFrameworkCore;
using System.Data.SqlTypes;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string Genre { get; set; }
    public int PublicationYear { get; set; }
    public int Pages { get; set; }
    public double Price { get; set; }
    public bool IsAvailable { get; set; }
    public double Rating { get; set; }
    public string Describtion { get; set; }
}

public class AppDbContext : DbContext
{
    public DbSet<Book> Books { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Database=postgres;Username=postgres;Password=1234");
    }
}

class Program
{
    static void Main()
    {
        var context = new AppDbContext();

        context.Database.EnsureCreated();

        context.Books.RemoveRange(context.Books); //очистка, чтобы не ныл

        context.Books.AddRange(
    new Book
    {
        Title = "Танец Ледяных Фонарей",
        Author = "Элисса Дюнбар",
        Genre = "Фэнтези",
        PublicationYear = 2018,
        Pages = 432,
        Price = 549,
        IsAvailable = true,
        Rating = 4.7,
        Describtion = "Когда арахнообразные фонари взмывают над заснеженными вершинами, молодая волшебница Лира отправляется в опасный путь, чтобы вернуть утраченное древнее пламя."
    },
    new Book
    {
        Title = "Пульс Марса",
        Author = "Максим Ветров",
        Genre = "Фэнтези",
        PublicationYear = 2022,
        Pages = 368,
        Price = 699,
        IsAvailable = true,
        Rating = 4.3,
        Describtion = "Колонисты Марса обнаруживают загадочный ритм, пульсирующий глубоко под поверхностью, который способен изменить представления человечества о жизни."
    },
    new Book
    {
        Title = "Тайна Старого Бульвара",
        Author = "Антон Воронов",
        Genre = "Детектив",
        PublicationYear = 2010,
        Pages = 284,
        Price = 399,
        IsAvailable = false,
        Rating = 4.1,
        Describtion = "В центре Парижа сыщик по прозвищу Сфинкс распутывает клубок лжи и предательства, оставленный тенью давно закрытого театра."
    },
    new Book
    {
        Title = "Роза среди шторма",
        Author = "Луиза Кармайкл",
        Genre = "Детектив",
        PublicationYear = 2020,
        Pages = 312,
        Price = 459,
        IsAvailable = true,
        Rating = 4.8,
        Describtion = "Судьбы двух влюблённых пересекаются на борту ветхого парусника, где ярость шторма проверит их чувства на прочность."
    },
    new Book
    {
        Title = "Шёпот Тёмного Леса",
        Author = "Виктория Чернова",
        Genre = "Ужасы",
        PublicationYear = 2015,
        Pages = 256,
        Price = 349,
        IsAvailable = true,
        Rating = 4.0,
        Describtion = "Группа друзей отправляется в запрещённую чащу, где каждое дерево хранит память о тех, кто навсегда исчез среди мрака."
    },
    new Book
    {
        Title = "Император и Журавли",
        Author = "Марко Фалько",
        Genre = "Ужасы",
        PublicationYear = 2008,
        Pages = 512,
        Price = 799,
        IsAvailable = false,
        Rating = 4.5,
        Describtion = "В разгар древней империи молодой поэт обретает любовь и предаёт трон, следуя за величественным журавлиным клином на север."
    },
    new Book
    {
        Title = "За гранью привычного",
        Author = "Ольга Андреева",
        Genre = "Биография",
        PublicationYear = 2021,
        Pages = 198,
        Price = 499,
        IsAvailable = true,
        Rating = 4.2,
        Describtion = "История жизни учёной, которая бросила всё, чтобы исследовать глубины океана и столкнулась с тем, что человечество ещё не готово понять."
    },
    new Book
    {
        Title = "Голос внутри",
        Author = "Сергей Лебедев",
        Genre = "Биография",
        PublicationYear = 2019,
        Pages = 224,
        Price = 299,
        IsAvailable = true,
        Rating = 4.9,
        Describtion = "Путеводитель по путешествию к себе: как научиться слушать внутренний голос и преодолевать любые преграды на пути к мечте."
    },
    new Book
    {
        Title = "Строфы забытого мира",
        Author = "Анна Миронова",
        Genre = "Поэзия",
        PublicationYear = 2016,
        Pages = 112,
        Price = 249,
        IsAvailable = true,
        Rating = 4.4,
        Describtion = "Сборник стихотворений о том, что остаётся невысказанным: о закатах, отражениях в воде и тишине между словами."
    },
    new Book
    {
        Title = "Приключения Лесика и Кнопки",
        Author = "Ирина Котляр",
        Genre = "Поэзия",
        PublicationYear = 2023,
        Pages = 96,
        Price = 199,
        IsAvailable = true,
        Rating = 4.6,
        Describtion = "Весёлые истории о храбром ёжике Лесике и любознательной мышке Кнопке, которые отправляются на поиски волшебного орешка."
    }
        );

        context.SaveChanges();

        Console.WriteLine("Таблица создана или обновлена");

        int q = 0;
        while (q == 0)
        {
            Console.WriteLine("Список всех книг:\n");
            var books = context.Books.ToList();
            foreach (var b in books)
            {
                Console.WriteLine($"{b.Id}: {b.Author}, {b.Title} - {b.Genre},\n" +
                    $"Дата публикации: {b.PublicationYear}, страниц: {b.Pages}, цена:" +
                    $"{b.Price}, доступность: {b.IsAvailable}, рейтинг: {b.Rating}\n" +
                    $"Краткое описание: {b.Describtion}");
            }

            Console.WriteLine("\nВыберите действие:\n" +
                "1 - Добавить книгу\n" +
                "2 - Обновление информации о книге\n" +
                "3 - Удаление книги\n" +
                "4 - Поиск книги по автору\n" +
                "5 - Поиск книги по жанру\n" +
                "6 - Поиск книги по году публикации\n" +
                "7 - Найти все книги до (n) цены\n" +
                "8 - Поиск по ключевым словам в описании книги\n" +
                "9 - Вычислить средний рейтинг книг по выбранному жанру\n" +
                "10 - Общее кол-во страниц всех книг\n" +
                "11 - Найти самую дорогую и самую дешевую книгу\n" +
                "12 - Выход\n");

            int chose = int.Parse(Console.ReadLine());

            switch (chose)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Введите Автора");
                    string chose1 = Console.ReadLine();
                    Console.WriteLine("Введите название");
                    string chose2 = Console.ReadLine();
                    Console.WriteLine("Введите жанр");
                    string chose3 = Console.ReadLine();
                    Console.WriteLine("Введите год публикации");
                    int chose4 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите кол-во страниц");
                    int chose5 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите цену");
                    int chose6 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите доступность (true/false)");
                    bool chose7 = bool.Parse(Console.ReadLine());
                    Console.WriteLine("Введите рейтинг");
                    double chose8 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите описание");
                    string chose9 = Console.ReadLine();

                    context.Books.AddRange(
                        new Book { Author = chose1, Title = chose2, Genre = chose3,
                            PublicationYear = chose4, Pages = chose5, Price = chose6,
                            IsAvailable = chose7, Rating = chose8, Describtion = chose9}
                    );

                    Console.WriteLine("Книга добавлена :), нажмите любую клавишу");
                    context.SaveChanges();
                    break;

                case 2:
                    Console.Write("\nВведите id книги: ");
                    int chos = int.Parse(Console.ReadLine());
                    var book = context.Books.Find(chos);

                    Console.Write("\nВведите что хотите поменять (Тут мы должны были спросить что хотим поменять " +
                        "но из-за этого получалось бы огромноге дерево if'a так что меняем только название): ");
                    string chos1 = Console.ReadLine();

                    if (book != null)
                    {
                        book.Title = chos1;

                        context.SaveChanges();
                        Console.WriteLine($"Название книги изменено на {book.Title} обновлена до {chos1}.");
                    }
                    break;

                case 3:
                    break;

                case 4:
                    break;

                case 5:
                    break;

                case 6:
                    break;

                case 7:
                    break;

                case 8:
                    break;

                case 9:
                    break;

                case 10:
                    break;

                case 11:
                    break;

                case 12:
                    q = int.Parse(Console.ReadLine());
                    break;


            }

            // Чтобы айди не добавлялся поверх с каждым запуском
            context.Database.ExecuteSqlRaw(@"TRUNCATE TABLE ""Books"" RESTART IDENTITY;");




        }

    }
}