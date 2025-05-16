using _12___Delegat.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12___Delegat.Delivery
{
    class LenghtDelivery : IDeliveryPrice
    {
        public int DeliveryPrice(int price, int lenght)
        {
            int number = lenght * 2;
            if (number < 250)
            {
                number = 250;
            }

            return number;
        }
    }
}
