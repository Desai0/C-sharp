using Microsoft.EntityFrameworkCore;
using System.Data.SqlTypes;
using System.Linq;

public class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Group { get; set; }
    public int[] Grades { get; set; }
    public Student(string firstName, string lastName, string group, int[] grades)
    {
        FirstName = firstName;
        LastName = lastName;
        Group = group;
        Grades = grades;
    }
}

class Program
{
    public static void Main()
    {
        var students = new List<Student>
            {
                new Student("Ivan",    "Petrov",    "A1", new[] {5, 4, 3, 5, 4}),
                new Student("Olga",    "Smirnova",  "A1", new[] {4, 4, 4, 4, 4}),
                new Student("Sergey",  "Ivanov",    "A1", new[] {3, 2, 4, 3, 3}),
                new Student("Marina",  "Kuznetsova","A1", new[] {5, 5, 5, 5, 5}),
                new Student("Dmitry",  "Sokolov",   "B1", new[] {2, 3, 2, 3, 2}),
                new Student("Elena",   "Popova",    "B1", new[] {4, 5, 4, 5, 4}),
                new Student("Alexey",  "Vasiliev",  "B1", new[] {3, 3, 3, 4, 3}),
                new Student("Natalia", "Mikhailova","B1", new[] {5, 4, 5, 4, 5}),
                new Student("Pavel",   "Fedorov",   "C1", new[] {2, 2, 3, 2, 2}),
                new Student("Svetlana","Morozova",  "C1", new[] {4, 4, 5, 4, 4}),
                new Student("Kirill",  "Volkov",    "C1", new[] {3, 5, 4, 3, 4}),
                new Student("Irina",   "Nikolaeva", "C1", new[] {5, 5, 4, 5, 5}),
                new Student("Yuri",    "Lebedev",   "D1", new[] {2, 3, 2, 3, 4}),
                new Student("Tatiana", "Semenova",  "D1", new[] {4, 5, 5, 4, 5}),
                new Student("Maxim",   "Novikov",   "D1", new[] {3, 3, 4, 3, 3}),
                new Student("Anastasia","Orlova",   "D1", new[] {5, 4, 4, 5, 4}),
                new Student("Vladimir","Petrovich", "E1", new[] {2, 2, 3, 2, 3}),
                new Student("Oksana",  "Orlova",    "E1", new[] {4, 4, 4, 5, 4}),
                new Student("Nikolay", "Antonov",   "E1", new[] {3, 4, 3, 4, 3}),
                new Student("Galina",  "Yakovleva", "E1", new[] {5, 5, 5, 4, 5})
            };


        Int16 q = 0;
        while (q == 0)
        {
            Console.WriteLine("Выберите действие: \n1. Найти всех студентов, у которых средний балл выше 4.\r\n2. Отсортировать студентов по фамилии и имени (в алфавитном порядке)." +
                "\r\n3. Получить список имён студентов, у которых хотя бы одна оценка равна 5.\r\n4. Сгруппировать студентов по группам и вычислить средний балл для каждой\r\nгруппы." +
                "\r\n5. Найти всех студентов из одной определенной группы, у которых средний балл\r\nвыше 4, отсортировать их по имени и вывести только фамилии\r\n6. Выход");

            Int16 choice = Int16.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Clear();
                    var goodStudents = students
                        .Where(x => x.Grades.Average() > 4);

                    foreach (var student in goodStudents)
                    {
                        Console.WriteLine($"{student.FirstName} {student.LastName} - {student.Grades.Average()}");
                    }
                    break;
                case 2:
                    Console.Clear();
                    var sortedStudents = students
                        .OrderBy(x => ((x.LastName), (x.FirstName)));

                    foreach (var student in sortedStudents)
                    {
                        Console.WriteLine($"{student.LastName} {student.FirstName}");
                    }
                    break;
                case 3:
                    Console.Clear();
                    var fiveInGrades = students
                        .Where(x => x.Grades.Contains(5));

                    foreach (var student in fiveInGrades)
                    {
                        Console.WriteLine($"{student.FirstName}");
                    }
                    break;
                case 4:
                    Console.Clear();
                    double bebra = 0;
                    var groupedStudents = students
                        .GroupBy(x => x.Group);

                    foreach (var group in groupedStudents)
                    {
                        Console.WriteLine($"Группа - {group.Key}, ");
                        foreach (var student in group)
                        {
                            bebra += student.Grades.Average();
                        }
                        bebra /= group.Count();
                        Console.Write($"средняя оценка: {bebra}\n");
                        bebra = 0;
                    }
                    break;
                case 5:
                    Console.Clear();
                    var slozno = students
                        .Where(x => x.Grades.Average() > 4)
                        .Where(x => x.Group == "A1")
                        .OrderBy(x => (x.FirstName));

                    foreach (var student in slozno)
                    {
                        Console.WriteLine($"{student.LastName}");
                    }
                    break;
                case 6:
                    Console.Clear();
                    q++;
                    break;

            }
        }
    }
}