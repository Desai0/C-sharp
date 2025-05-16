using _11___Classes_Task.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11___Classes_Task
{
    internal interface IPaymentValidator
    {
        bool ValidatePayment(Buyer getter, Buyer setter, Buyer getterOld, Buyer setterOld, int Sum);
    }
}
