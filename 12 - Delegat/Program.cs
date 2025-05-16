using _12___Delegat.Delivery;
using _12___Delegat.Interfaces;

class Program
{
    //public delegate int DelegateE(int price, int lenght);
    static void Main()
    {
        Int16 q = 0;
        while (q == 0)
        {
            Console.WriteLine("Введите стоимость товара и расстояние: ");

            

            int price = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());

            

            LenghtDelivery lenghtDelivery = new LenghtDelivery();
            PricePercDelivery pricePercDelivery = new PricePercDelivery();
            FixedDelivery fixedDelivery = new FixedDelivery();

            //DelegateE delegateE;
            //delegateE = lenghtDelivery.DeliveryPrice;
            //delegateE += pricePercDelivery.DeliveryPrice;
            //delegateE += fixedDelivery.DeliveryFixedPrice;

            int lenghtDel = lenghtDelivery.DeliveryPrice(price, lenght);
            int pricePercDel = pricePercDelivery.DeliveryPrice(price, lenght);
            int fixedDel = fixedDelivery.DeliveryFixedPrice();

            //delegateE(price, lenght);

            Console.WriteLine($"Выберите способ расчета доставки: \n" +
                $"1 - Фиксированная стоимость ({fixedDel} рублей)\r\n2 - Процент от стоимости ({pricePercDel} рублей)\r\n3 - Зависимость от расстояния ({lenghtDel} рублей)\r\n");

            Int16 choice = Int16.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Спасибо за заказ, выбран вариант: Фиксированная стоимость, за {fixedDel} рублей ");

                    break;
                case 2:
                    Console.WriteLine($"Спасибо за заказ, выбран вариант: Процент от стоимости, за {pricePercDel} рублей ");

                    break;
                case 3:
                    Console.WriteLine($"Спасибо за заказ, выбран вариант: Зависимость от расстояния, за {lenghtDel} рублей ");

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
            }
        }
    }
}


//Задание 2

//(подсказка) необходимо реализовать паттерн Наблюдатель
//Разработайте систему мониторинга состояния серверов, которая уведомляет администраторов о проблемах. Используйте события для реализации механизма уведомлений.

//Условие:
//Создайте класс ServerMonitor, который будет проверять состояние сервера и генерировать событие при возникновении проблемы.
//Реализуйте два типа уведомлений:
//Отправка email-сообщения.
//Отправка SMS-сообщения.
//Подпишите оба метода на событие ServerDown в классе ServerMonitor.
//В методе CheckServerStatus случайным образом эмулируйте проблемы с сервером.
//Выведите уведомления в консоль.
