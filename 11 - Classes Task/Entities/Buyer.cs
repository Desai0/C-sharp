using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11___Classes_Task.Entities
{
    public class Buyer
    {
        public string _name;
        public int _money;

        public Buyer(string name, int money)
        {
            _name = name;
            _money = money;
        }

        public string Name => _name;
        public int Money => _money;

        public void Paying(int sum)
        {
            _money -= sum;
        }

        public void Getting(int sum)
        {
            _money += sum;
        }
    }

}
