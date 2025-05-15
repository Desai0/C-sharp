using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___Class_Exmpl.Tools
{
    public class ShopsException : Exception
    {
        public ShopsException()
        {
        }

        public ShopsException(string message)
            : base(message)
        {
        }

        public ShopsException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }

}
