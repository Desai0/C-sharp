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