using System;

//public class Vehicle
//{
//    public virtual void Move() // virtual - может быть переопределен в наследниках
//    {

//    }
//}

//public class Car : Vehicle // наследование (нет множественного наследования)
//{
//    public override void Move() // override - переопределение
//    {
//        base.Move(); // использовать/вызвать базовый метод класса
//        Console.WriteLine(); // если переопределения нет, то и  base. не надо
//    }
//}

//public abstract class Vehicle
//{
//    public string Brand { get; set; }
//    public void DisplayInfo()
//    {

//    }

//    public abstract void Beep(); // абстрактный метод - метод который мы объявляем в абстрактном классе и в нем он не имеет реализации, но в классах наследниках он обязательно должен быть реализован
//}

//public class Car : Vehicle // наследование (нет множественного наследования)
//{
//    public override void Beep()
//    {
//        Console.WriteLine("Beep!");
//    }
//}

//public class Plane : Vehicle // наследование (нет множественного наследования)
//{
//    public override void Beep()
//    {
//        Console.WriteLine("Gook!");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        //Vehicle vehicle = new Vehicle; // Нельзя из-за  abstract
//        Vehicle vehicle = new Plane();
//        Vehicle vehicle2 = new Car();

//        Vehicle[] vehicles = { new Plane(), new Car() }; // экземпляр класса самолет и машины
//    }
//}


interface IMove // это контракт который показывает, что должно обязательно быть реализовано в наследуемом классе, без реализации тут и модификаторов доступа
{
    void Move();
}

// Различия абстр класса и интерфейса
// Абстрактный класс - когда нам нужно представить какую-то функциональность + это абстракная сущность. От которой наследуются какие-то классы, которые реализиют какую-то разную шнягу
// Интерфейс - чтобы определить какие методы должны быть в этих классов но без реализаций

// в классах есть свойства и поля, в интерфейсах их нет
interface IBeep // чтобы отобразить в методы в классе короче. интерфейс называть с буквы I
{ // интерфейс - аналог .h файлов, лучше тоже выносить в отдельный файл
    void Beep();
}

public class Car : IBeep, IMove // наследование (нет множественного наследования)
{
    public void Beep()
    {

    }

    public void Move() // ОБЯЗАТЕЛЬНАЯ РЕАЛИЗАЦИЯ, т.к. наследуем
    {

    }
}

public class Plane : IMove // наследование (нет множественного наследования)
{
    public void Move()
    {

    }
}

class Program
{
    static void Main()
    {
         
    }
}