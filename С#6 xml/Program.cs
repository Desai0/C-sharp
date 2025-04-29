using System.Collections.Generic;
using System.Xml.Linq;

//class Program
//{
//    static void Main()
//    {
//        // Загрузка из файла
//        XDocument document = XDocument.Load("C:\\Users\\studentcoll\\Documents\\bebra\\С#2\\С#6 xml\\xml.xml");

//        // Descendants - все на всех уровнях
//        var names = document.Descendants("Name"); // tom bob все

//        // Elements - все на одном уровне
//        var names2 = document.Elements("Name"); // tom bob чтобы лишнее не взять

//        // Element - 
//        var names3 = document.Element("Name"); // tom только первое


//        //загрузка из строки
//        string xmlString = @"<Root><Element>Value</Element></Root>";
//        XDocument document2 = XDocument.Parse(xmlString);

//        // XDocument, XElement
//        XDocument contacts = new XDocument(
//            new XElement("Contacts",
//                new XElement("Contact",
//                    new XElement("Name", "Tom"),
//                    new XElement("Phone", "123456789")
//                ),
//                new XElement("Contact",
//                    new XElement("Name", "Bob"),
//                    new XElement("Phone", "987654321")
//                )
//            )
//       );

//        contacts.Save("C:\\Users\\studentcoll\\Documents\\bebra\\С#2\\С#6 xml\\xml.xml");

//    }
//}


class Program
{
    static void Main()
    {
        XDocument task = XDocument.Load("C:\\Users\\studentcoll\\Documents\\bebra\\С#2\\С#6 xml\\task.xml");

        var electronicsProducts = task.Root.Elements("Product")
            .Where(x =>
                x.Element("Category") != null && x.Element("Category").Value == "Electronics");

        foreach (var product in electronicsProducts)
        {
            string productId = product.Attribute("Id")?.Value;
            string productName = product.Element("Name")?.Value;
            string productAvailable = product.Element("Available")?.Value;

            Console.WriteLine($"ID: {productId}, Название: {productName}, доступ к покупке: {productAvailable}");
        }

        var priceNcheap = task.Root.Elements("Product")
            .Where(x => x.Element("Price") != null && int.Parse(x.Element("Price").Value) < 1000);

        foreach (var product in electronicsProducts)
        {
            string productId = product.Attribute("Id")?.Value;
            string productName = product.Element("Name")?.Value;
            string productPrice = product.Element("Price")?.Value;

            Console.WriteLine($"ID: {productId}, Название: {productName}, можно купить дешевле 1000!: {productPrice} рублей");
        }



    }
}