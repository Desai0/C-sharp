using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12___Delegat.Delivery
{
    class FixedDelivery
    {
        public int DeliveryFixedPrice()
        {
            Random rnd = new Random();
            int value = rnd.Next(609, 1048);
            return value;
        }
    }
}
