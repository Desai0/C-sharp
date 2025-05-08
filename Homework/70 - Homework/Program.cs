class Program
{
    static void Main()
    {
        string[][] movies = {
            new string[] { "Матрица", "Интерстеллар", "Время" }, // Фантастика
            new string[] { "Крёстный отец", "Казино", "Славные парни" }, // Криминал
            new string[] { "Аватар", "Человек-паук", "Железный человек" } // Экшн
        };


        string[] genres = { "Фантастика", "Криминал", "Экшн" };
        for (int i = 0; i < movies.Length; i++)
        {
            Console.WriteLine($"Жанр: {genres[i]}");
            for (int j = 0; j < movies[i].Length; j++)
            {
                Console.WriteLine($" - {movies[i][j]}");
            }
        }
        //foreach
        foreach (var genre in genres)
        {
            Console.WriteLine($"Жанр: {genre}");
        }

        foreach (var movie in movies)
        {
            foreach (var m in movie)
            {
                Console.WriteLine($" - {m}");
            }
        }
    }
}