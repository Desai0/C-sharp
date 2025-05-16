using _11___Classes_Task.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11___Classes_Task
{
    internal interface IPaymentProcessor
    {
        void ProcessPayment(ref Buyer getter, ref Buyer sender, int Sum);

        void RefundPayment(ref Buyer getter, ref Buyer sender, int Sum);
    }
}
