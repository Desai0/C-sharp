using _12___Delegat.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12___Delegat.Delivery
{
    class PricePercDelivery : IDeliveryPrice
    {
        public int DeliveryPrice(int price, int lenght)
        {
            int number = price / 6;

            return number;
        }
    }
}
