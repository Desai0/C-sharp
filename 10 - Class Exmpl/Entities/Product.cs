using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shops.Entities
{
    public class Product
    {
        private string _name; // Создаем поле
        private int _amount; // Поля принято писать с "_м"
        private int _price;

        public Product(string product, int amount, int price)
        {
            _name = product;
            _amount = amount;
            _price = price;
        }

        public string Name => _name; // прописываем свойства
        public int Price => _price;
        public int Amount => _amount;

        public void AddPrice(int price)
        {
            _price = price; // setters
        }

        public void RemoveAmount(int difference)
        {
            _amount -= difference; // setters
        }
    }
}

