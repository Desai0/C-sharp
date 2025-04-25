//class Program
//{
//    static void Main()
//    {
//        //bool
//        //string
//        int hello;
//        const double Hello = 3.13;

//        string greeting = "Hello";
//        Console.WriteLine(greeting);
//        Console.ReadKey();
//        Console.WriteLine($"Say hello - {greeting}");
//        Console.WriteLine("Say hello - {0}, {1}", 5, 10);

//        Console.Clear();

//        string? enter = Console.ReadLine(); // ? - значение может быть NULL

//        double? enter2 = Convert.ToDouble(Console.ReadLine());


//        int n = 10, m = 5;

//        double k = n + m;
//        Console.WriteLine(k);

//        if (n < 10)
//        {
//            Console.WriteLine(k + 10);
//        } else
//        {
//            Console.WriteLine(k - 10);
//        }


//        string res = (n % 2 == 0) ? "Четное" : "Нечетное";
//        Console.WriteLine(res);

//        switch(n)
//        {
//            case 0:
//                break;
//            case 1:
//                break;
//        }
//    }

//    //static int Main(string[] args)
//}



class Calculate
{
    static void Main()
    {
        int q = 0;
        while (q == 0)
        {

            Console.WriteLine("Hello user, please enter 2 numbers");
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            double firstC = Convert.ToDouble(first);
            double secondC = Convert.ToDouble(second);

            Console.WriteLine("Enter operation: '+,-,/,*'");
            char operation = char.Parse(Console.ReadLine());
            double result = 0;
            if (operation == '+')
            {
                result = firstC + secondC;
            } 
            else if (operation == '-')
            {
                result = firstC - secondC;
            }
            else if (operation == '/')
            {
                if (secondC == 0)
                {
                    Console.WriteLine("U cant division with 0");
                    break;
                } else
                {
                    result = firstC / secondC;
                }
            }
            else if (operation == '*')
            {
                result = firstC * secondC;
            } else
            {
                Console.WriteLine("You entered some shit");
                break;
            }

            Console.WriteLine("Tap something lol");

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine($"Result: {result}");

            Console.WriteLine("Enter 1 if u want to stop, 0 to continue");
            q = int.Parse(Console.ReadLine());
            Console.Clear();
        }
    }
    
}