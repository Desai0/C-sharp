class Program
{
    static void Main()
    {
        HashSet<int> list = new HashSet<int>(); // В множестве уникальные элементы

        list.Add(10);
        list.Add(1);
        list.Add(3);

        list.Remove(10); // удаление элемента

        list.Clear();

        bool cont = list.Contains(3); // тру фалс по числу

        int count = list.Count(); // кол-во элементов


    }
}