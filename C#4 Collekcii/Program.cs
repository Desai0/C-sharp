using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> ints = new List<int>();
        List<int> ints2 = new List<int>() {1, 2 };

        ints.Add(1);

        ints.AddRange(ints2);
        ints.AddRange(new List<int> {1, 2, 3 });

        // ints = {1,2,3}
        ints.Insert(1, 5); // на 1 индекс - 5 {1,5,2,3}
        ints.InsertRange(1, new List<int> { 4, 5 }); // Начиная с 1 индекса, добавятся 1, 2, 3 {1, 4, 5, 2, 3}

        // {4, 3, 5, 2, 7, 2}
        ints.Remove(2); // удаление первого числа 2, которое он находит в массиве {4, 3, 5, 7, 2}
        ints.RemoveAt(0); // Удаление по индексу {3, 5, 2, 7, 2}
        ints.RemoveRange(1, 3); // удаляем с 1 индекса 3 элемента {4, 7, 2}
        ints.RemoveAll(x => x % 2 == 0); // лямбда. Проверь по каждому значению листа и удали совпадения
        ints.Clear();

        bool res = ints.Contains(1); // если 1 есть в листе, то True
        int num = ints.Find(x => x % 2 == 0); // помещает элемент, подходящий по условию в переменную
        List<int> ints3 = ints.FindAll(x => x % 2 == 0);

        // {4, 3, 5, 2, 7, 2}
        List<int> ints4 = ints.GetRange(1, 3); // {3, 5, 2}

        ints.Reverse(); //переворачивает лист

        ints.Count() // число элементов в листе
    }
}