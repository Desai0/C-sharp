using System.Collections.Generic;

class Programm
{
    static void Main()
    {
        Dictionary<string, int> dic = new Dictionary<string, int>();

        dic.Add("Ann, 25");
        dic.Add("Tom, 30");

        dic["Ann"] = 33; // изменит знач
        dic["Sam"] = 33; // добавит

        dic.Remove("Ann");
        dic.Clear();

        bool a = dic.ContainsKey("Ann");
        bool b = dic.ContainsValue(20);

        bool res = dic.TryGetValue("Tom", out var age); // если Tom не сущ, то будет False, Если сущ. то True и в age будет значение

        dic.Count();

    }
}