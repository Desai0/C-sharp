using Microsoft.EntityFrameworkCore;
using System.Data.SqlTypes;
using System.Xml.Linq;

class Program
{
    public static void Main()
    {
        XDocument task = XDocument.Load("..\\..\\..\\task.xml");

        Int16 q = 0;
        while (q == 0)
        {
            Console.WriteLine("1.Поиск элементов:\n" +
" ● Найдите всех сотрудников из отдела IT.\n" +
"2.Фильтрация:\n" +
" ● Найдите сотрудников, работающих над более чем одним проектом.\n" +
"3.Модификация XML:\n" +
" ● Добавьте нового сотрудника в XML.\n" +
" ● Обновите должность существующего сотрудника.\n" +
" ● Удалите сотрудника из XML.\n" +
"4.Преобразуйте XML в список объектов C# (класс Employee)\r\n5. Выход");

            Int16 choice = Int16.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Clear();
                    var itSector = task.Root.Elements("Employee")
                        .Where(x => x.Element("Department") != null && x.Element("Department").Value == "IT");

                    foreach (var people in itSector)
                    {
                        string peopleName = people.Element("FirstName")?.Value;
                        Console.Write($"{peopleName}, ");
                    }
                    Console.WriteLine($"работают в IT секторе");
                    break;
                case 2:
                    var projects = task.Root.Elements("Employee")
                        .Where(x => x.Descendants("Project").Count() > 1);

                    foreach (var item in projects)
                    {
                        Console.WriteLine($"{item.Element("FirstName").Value} {item.Element("LastName").Value}");
                    }

                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    q++;
                    break;
            }
        }
                    
    }
}