using System.Xml.Linq;
using System.Collections.Generic;

class Departament
{
    public int Id { get; set; }

    public string Name { get; set; }

    public Departament(int id, string name)
    {
        Id = id;
        Name = name;
    }
}

class Employee
{
    public int DepartamentId { get; set; }

    public string Name { get; set; }

    public Employee(int departamentId, string name)
    {
        DepartamentId = departamentId;
        Name = name;
    }
}


class Person
{
    public string Name { get; set; }

    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

class Program
{
    static int Main()
    {
        int[] nums1 = { 1, 2, 3, 4, 5 };
        int[] nums2 = { 4, 5, 6, 7 };

        // Concat - объединение без удаления дубликатов
        var nums3 = nums1.Concat(nums2);

        foreach (var i in nums3)
        {
            Console.WriteLine(i);
        }

        // Distinct - удаление дубликатов
        var distinct = nums3.Distinct();

        foreach (var i in nums3)
        {
            Console.WriteLine(i);
        }

        // Union - Объединение с исключением дубликатов
        var union = nums1.Union(nums2);

        // Intersect - пересечение коллекций
        var intersect = nums1.Intersect(nums2);

        // Except - поиск элементов, которые содержатся только в первой коллекции
        var except = nums1.Except(nums2);

        foreach (var i in except)
        {
            Console.WriteLine(i);
        }

        // Skip - пропустить n элементов
        // Take - выбирает n элементов
        var nums4 = nums1.Skip(2).Take(2); // 3, 4

        // SkipWhile - пропускает элементы пока верно какое-то условие
        // TakeWhile - выбирает элементы пока верно какое-то условие
        var evenNums3 = nums1.SkipWhile(x => x < 4);

        var nums5 = nums1.TakeWhile(x => x < 4);


        foreach (var i in nums5)
        {
            Console.WriteLine(i);
        }




        var departments = new List<Departament>
        {
            new Departament(1, "HR"),
            new Departament(2, "IT"),
        };

        var employees = new List<Employee>
        {
            new Employee(1, "Alice"),
            new Employee(2, "Bob"),
            new Employee(1, "David")
        };

        var employeeDepartament = departments.Join( // 1 коллекция
            employees, // 2 коллекция
            d => d.Id, // ключ 1 коллекции
            e => e.DepartamentId, // ключ 2 коллекции
            (d, e) => new { DepartamentName = d.Name, EmployeeName = e.Name }
            );
        foreach (var item in employeeDepartament)
        {
            Console.WriteLine($"{item.EmployeeName} работает в {item.DepartamentName}");
        }



        var people = new List<Person>()
        {
            new Person("Tom", 25),
            new Person("Bob", 22),
            new Person("Alice", 22),
            new Person("David", 25)
        };

        var groupedPeople = people
            .GroupBy(p => p.Age);

        foreach (var group in groupedPeople)
        {
            Console.WriteLine($"Возраст: {group.Key}"); //как словарь, ключ - значение, сначала берем кей из group, потом group распоковываем до person
            foreach (var person in group)
            {
                Console.WriteLine(person.Name);
            }
        }





        int[] nums = { 1, 2, 3, 4, 5 };

        var evenNums = nums.Where(x => x % 2 == 0);

        var evenNums2 = from x in nums
                        where x % 2 == 0
                        select x;

        string[] names = { "Loh", "Loh21", "Loh3" };

        var sortedNames = names.OrderBy(x => x.Length);

        var sortedNames3 = names.OrderByDescending(x => x.Length); // в обратную сторону

        foreach (var name in sortedNames)
        {
            Console.WriteLine(name);
        }


        var sortedNames2 = from name in names
                           orderby name.Length
                           select name;



        var squares = nums.Select(x => x * x);

        foreach (var name in squares)
        {
            Console.WriteLine(name);
        }

        var squares2 = from x in squares
                       select x;


        int count = nums.Count();
        int sum = nums.Sum();
        int min = nums.Min();
        int max = nums.Max();
        double av = nums.Average();

        var result = nums
            .Where(x => x % 2 != 0)
            .OrderByDescending(x => x)
            .Select(x => x * x);


        return 0;
    }
}