using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using _11___Classes_Task.Entities;

namespace _11___Classes_Task.Processes
{
    class CreditCardProcessor : IPaymentProcessor, IPaymentValidator
    {
        public void ProcessPayment(ref Buyer getter, ref Buyer sender, int Sum)
        {

            int OldGetter = getter.Money;
            int OldSetter = sender.Money;

            if (sender.Money < Sum)
            {
                RefundPayment(ref getter, ref sender, Sum);
            } else
            {
                ValidatePayment(getter, sender, Sum, OldGetter, OldSetter);
            }
        }

        public void RefundPayment(ref Buyer getter, ref Buyer sender, int Sum)
        {

            getter.Paying(Sum);
            sender.Getting(Sum);

            
        }

        public bool ValidatePayment(Buyer getter, Buyer sender, int Sum, int OldGetter, int OldSetter)
        {
            if (getter.Money - Sum == OldGetter - Sum && sender.Money + Sum == OldSetter + Sum)
            {
                getter.Getting(Sum);
                sender.Paying(Sum);

                Console.WriteLine("True");
                return true;
            } else
            {
                Console.WriteLine("False");
                return false;
            }
        }
    }
}
