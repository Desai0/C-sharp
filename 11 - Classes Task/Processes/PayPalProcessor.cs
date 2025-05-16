using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _11___Classes_Task.Entities;

namespace _11___Classes_Task.Processes
{
    class PayPalProcessor : IPaymentProcessor
    {
        public void ProcessPayment(ref Buyer getter, ref Buyer sender, int Sum)
        {

            if (sender.Money < Sum)
            {
                RefundPayment(ref getter, ref sender, Sum);
            }
        }

        public void RefundPayment(ref Buyer getter, ref Buyer sender, int Sum)
        {
            getter.Getting(Sum);
            sender.Paying(Sum);
        }
    }
}
