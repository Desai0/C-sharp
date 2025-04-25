//class Program
//{
//    static void Main()
//    {
//        //Создание объекта для генерации чисел
//        Random rnd = new Random();
        

//        int oil = 100;

//        for (int i = 1; i < 11; i++)
//        {
//            //Получить случайное число (в диапазоне от 0 до 10)
//            int rand = rnd.Next(5, 15);
//            oil = oil - rand;

//            Console.WriteLine($"Потрачено на {i} перелете: {rand} топлива, осталось: {oil} литров");
            
//        }
//        if (oil >= 0)
//        {
//            Console.WriteLine("Успех, перелет удался");
//        } else
//        {
//            Console.WriteLine("Неудача, топливо кончилось");
//        }
//    }
//}

//class Program2
//{
//    static void Main()
//    {
//        Random rnd = new Random();
//        int rand = rnd.Next(1, 10);
//        int i = 0;

//        while (rand != 1) {
//            i += 1;
//            Console.WriteLine($"Клад не найден. Потрачено попыток {i}");
//            rand = rnd.Next(1, 10);
//        }
//        i += 1;
//        Console.WriteLine($"\nКлад найден. Потрачено попыток {i}");

//    }
//}


//class Program3
//{
//    static void Main()
//    {
//        Random rnd = new Random();
//        int rand = rnd.Next(1, 101);

//        Console.WriteLine("Число загадано, впишите догадку: ");
//        int user = Convert.ToInt32(Console.ReadLine());
//        int i = 0;

//        do
//        {
//            i = i + 1;
//            if (user < rand)
//            {
//                Console.WriteLine("Ваше число меньше, еще попытка: ");
//            } else
//            {
//                Console.WriteLine("Ваше число больше, еще попытка: ");
//            }

//            user = Convert.ToInt32(Console.ReadLine());
//        } while (user != rand);

//        i = i + 1;
//        Console.WriteLine($"Верно, вы угадали, количество попыток: {i}");
//    }
//}


class Program4
{
    static void Main()
    {
        string[] paintings = { "Мона Лиза", "Звёздная ночь", "Девушка с жемчужиной", "Ночной дозор" };
        int i = 0;
        foreach (var num in paintings)
        {
            i++;
            Console.WriteLine($"Картина {i}: {num}");
        }

    }
}