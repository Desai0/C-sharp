
using _11___Classes_Task.Processes;
using _11___Classes_Task.Entities;

class Program
{
    static void Main()
    {
        Buyer seller = new Buyer("Аким Нищук", 69);

        Console.WriteLine("Введите данные о себе: \n" +
            "1 - Имя\n" +
            "2 - Ваше кол-во деняк");
        string userName = Console.ReadLine();
        int userMoney = int.Parse(Console.ReadLine());

        Buyer user = new Buyer(userName, userMoney);

        Int16 q = 0;
        while (q == 0)
        {

            Console.WriteLine("Выберите метод оплаты:\n" +
                "1 - PayPal\n" +
                "2 - Credit Card\n" +
                "3 - Crypto");
            Int16 choice = Int16.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Введите кол-во денег за товар: ");
                    int givingMoney = int.Parse(Console.ReadLine());
                    while (!int.TryParse(Console.ReadLine(), out givingMoney) || givingMoney <= 0)
                    {
                        Console.WriteLine("Некорректное значение. Введите положительное число для суммы товара:");
                    }

                    // 1. Создаем экземпляр PayPalProcessor
                    PayPalProcessor payPalService = new PayPalProcessor();

                    Console.WriteLine($"\nПопытка платежа: {user.Name} платит {seller.Name} сумму {givingMoney}");
                    Console.WriteLine($"Баланс {user.Name} до: {user.Money}");
                    Console.WriteLine($"Баланс {seller.Name} до: {seller.Money}");

                    // 2. Вызываем метод ProcessPayment, используя ref для seller и user
                    // В вашем контексте: user - это sender (отправитель), seller - это getter (получатель)
                    payPalService.ProcessPayment(ref seller, ref user, givingMoney);

                    Console.WriteLine($"\nРезультат операции:");
                    Console.WriteLine($"Баланс {user.Name} после: {user.Money}");
                    Console.WriteLine($"Баланс {seller.Name} после: {seller.Money}\n");


                    break;
                case 2:

                    break;
                case 3:

                    break;


            }
            if (q == 0)
            {
                Console.WriteLine("Нажмите любую клавишу для продолжения...");
                Console.ReadKey();
                Console.Clear(); // Очистим консоль для следующей итерации
                                 // Повторно выведем информацию об участниках, если они изменились
                Console.WriteLine($"Продавец: {seller}");
                Console.WriteLine($"Покупатель: {user}\n");
            }
        }
    }
}