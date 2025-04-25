using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<int> stack = new Stack<int>();

        stack.Push(1); //добавление элемента
        int r = stack.Pop(); // удаление элемента
        int q = stack.Peek(); // возвращение элемента

        stack.Clear();
        bool w = stack.Contains(10);
        int u = stack.Count();



    }
}