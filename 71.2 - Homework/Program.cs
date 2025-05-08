using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Int16 q = 0;
        string item;

        Dictionary<string, int> inventory = new Dictionary<string, int>();

        inventory.Add("Меч", 1);
        inventory.Add("Щит", 2);
        inventory.Add("Зелье здоровья", 5);


        while (q == 0)
        {
            Console.WriteLine("Выберите действие:\n" +
            "1. Добавление предмета в инвентарь (если предмет уже есть, увеличьте его\r\nколичество).\r\n2. Удаление предмета из инвентаря (если количество достигает нуля, удалите его\r\nполностью).\r\n" +
            "3. Просмотр текущего содержимого инвентаря.\r\n4. Поиск предмета по названию и вывод его количества.\r\n5. Выход");

            UIntPtr chose = UIntPtr.Parse(Console.ReadLine());
            int qq;
            switch (chose)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Введите название предмета: ");
                    item = Console.ReadLine();
                    if (inventory.ContainsKey(item)) 
                    {
                        inventory[item]++;
                    } 
                    else
                    {
                        inventory.Add(item, 1);
                    }


                        break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Введите название предмета: ");
                    item = Console.ReadLine();
                    if (inventory.ContainsKey(item))
                    {
                        inventory[item] -= 1;
                        if (inventory[item] <= 0)
                        {
                            inventory.Remove(item);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Такого предмета нет в инвентаре");
                    }
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Текущий инвентарь: ");
                    foreach (var shnyaga in inventory)
                    {
                        Console.WriteLine($"{shnyaga.Key} - {shnyaga.Value}");
                    }
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Введите название предмета: ");
                    item = Console.ReadLine();
                    if (inventory.ContainsKey(item))
                    {
                        Console.WriteLine($"{inventory[item]}");
                    }
                    break;
                case 5:
                    q++;
                    break;

            }

        }
    }
}