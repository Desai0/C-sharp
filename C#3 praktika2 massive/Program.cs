//class Program
//{
//    static void Main()
//    {
//        int[] nums4 = { 85, 92, 78, 90, 67 };
//        double average = 0;
//        double medium = 80;
//        int student_quantity = 0;

//        foreach (var num in nums4)
//        {
//            average = average + num;
//            if (num > medium)
//            {
//                student_quantity++;
//            }
//        }

//        average = average / nums4.Length;
//        Console.WriteLine($"Средняя оценка: {average}");
//        Console.WriteLine($"Количество студентов с оценкой выше средней: {student_quantity}");

//        for (int j = 0; j < nums4.Length; j++)
//        {
//            for (int i = 0; i < nums4.Length - 1; i++)
//            {
//                if (nums4[i] > nums4[i + 1])
//                {
//                    int b = nums4[i];
//                    nums4[i] = nums4[i + 1];
//                    nums4[i + 1] = b;
//                }
//            }
//        }

//        Console.Write($"Отсортированный списко оценок: ");
//        foreach (var num in nums4)
//        {
//            Console.Write($"{num} ");
//        }
//    }
//}


/*class Program2
{
    static void Main()
    {
        //int[,] labirint =
        //{
        //    {0, 1, 1, 0, 1 },
        //    {0, 1, 0, 0, 1 },
        //    {0, 1, 0, 1, 0 },
        //    {0, 1, 0, 0, 0 },
        //    {0, 0, 0, 1, 1 }
        //};
        int[,] labirint = new int[5, 5];

        Console.WriteLine("Введите 5 цифр (0 или 1) для каждой из строк лабиринта");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                int g = int.Parse(Console.ReadLine());
                labirint[i, j] = g;
            }


        }

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write($"{labirint[i, j]} ");
            }
            Console.Write("\n");
        }



        bool prohod = true;
        if (labirint[0, 0] == 0)
            {
                int i = 0; 
                int j = 0;
                while (i != 4)
                {
                    if (labirint[i, j + 1] == 0)
                    {
                        j++;
                        if (labirint[i+1, j] == 0)
                        {
                            i++;
                        } else
                        {
                            Console.WriteLine("Пройти по краю нельзя");
                            break;
                        }
                        

                    }
                }

                if (!(i == 4 && j == 4))
                {
                    while (j != 4)
                    {
                        if (labirint[i+1, j] == 0)
                        {
                            i++;
                            if (labirint[i, j+1] == 0)
                            {
                                j++;
                            }
                            else
                            {
                                Console.WriteLine("Пройти по краю нельзя");
                                break;
                            }
                            

                        }
                    }
                }
            Console.WriteLine("Успех, пройти по краю можно");

        }
        else
            {
                Console.WriteLine("В начале стена");
            }
    }
}*/


class Program3
{
    static void Main()
    {
        int[][] cities = {
            new int[] { 10000, 15000, 20000 }, // Город 1
            new int[] { 5000, 7000 },         // Город 2
            new int[] { 30000, 40000, 50000, 60000 } // Город 3
        };

        int summ = 0;
        int town_number = 0;
        for (int i = 0; i < cities.Length; i++)
        {
            for (int j = 0; j < cities[i].Length; j++)
            {
                summ = summ + cities[i][j];
            }
            Console.WriteLine($"Город {i+1}: Общее население = {summ}");
            
            if (summ > town_number)
            {
                town_number = i + 1;
            }
            summ = 0;
        }
        Console.WriteLine($"Самый большой город: {town_number}");
    }
}