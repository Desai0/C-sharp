
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
                "3 - Crypto\n" +
                "4 - Выход");
            Int16 choice = Int16.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Баланс {user.Name} на данный момент: {user.Money}");
                    Console.WriteLine($"Баланс {seller.Name} на данный момент: {seller.Money}");

                    Console.WriteLine("Введите кол-во денег за товар: ");
                    int givingMoney;
                    while (!int.TryParse(Console.ReadLine(), out givingMoney) || givingMoney <= 0)
                    {
                        Console.WriteLine("Некорректное значение. Введите положительное число для суммы товара:");
                    }

                    // 1. Создаем экземпляр PayPalProcessor
                    PayPalProcessor payPalService = new PayPalProcessor();

                    Console.WriteLine($"\nПопытка платежа: {user.Name} платит {seller.Name} сумму {givingMoney}");

                    // 2. Вызываем метод ProcessPayment, используя ref для seller и user
                    payPalService.ProcessPayment(ref seller, ref user, givingMoney);

                    Console.WriteLine($"\nРезультат операции:");
                    Console.WriteLine($"Баланс {user.Name} на данный момент: {user.Money}");
                    Console.WriteLine($"Баланс {seller.Name} на данный момент: {seller.Money}\n");

                    break;
                case 2:
                    Console.WriteLine($"Баланс {user.Name} на данный момент: {user.Money}");
                    Console.WriteLine($"Баланс {seller.Name} на данный момент: {seller.Money}");

                    Console.WriteLine("Введите кол-во денег за товар: ");

                    while (!int.TryParse(Console.ReadLine(), out givingMoney) || givingMoney <= 0)
                    {
                        Console.WriteLine("Некорректное значение. Введите положительное число для суммы товара:");
                    }

                    // 1. Создаем экземпляр PayPalProcessor
                    CreditCardProcessor creditCardProcessor = new CreditCardProcessor();

                    Console.WriteLine($"\nПопытка платежа: {user.Name} платит {seller.Name} сумму {givingMoney}");

                    // 2. Вызываем метод ProcessPayment, используя ref для seller и user
                    creditCardProcessor.ProcessPayment(ref seller, ref user, givingMoney);

                    Console.WriteLine($"\nРезультат операции:");
                    Console.WriteLine($"Баланс {user.Name} на данный момент: {user.Money}");
                    Console.WriteLine($"Баланс {seller.Name} на данный момент: {seller.Money}\n");

                    break;
                case 3:

                    break;
                case 4:
                    q++;
                    break;


            }
            if (q == 0)
            {
                Console.WriteLine("Нажмите любую клавишу для продолжения...");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine($"Продавец: {seller}");
                Console.WriteLine($"Покупатель: {user}\n");
            }
        }
    }
}


//Задание 2
//Разработайте систему бронирования для туристического агентства:
//Создайте абстрактный класс Reservation с:
//Свойствами: ReservationID, CustomerName, StartDate, EndDate
//Абстрактным методом CalculatePrice()
//Виртуальным методом DisplayDetails()
//Создайте производные классы:
//HotelReservation(добавляет RoomType и MealPlan)
//FlightReservation(добавляет DepartureAirport и ArrivalAirport)
//CarRentalReservation(добавляет CarType и InsuranceOptions)
//Создайте класс BookingSystem с методами:
//CreateReservation(reservationType)
//CancelReservation(reservationID)
//GetTotalBookingValue()
