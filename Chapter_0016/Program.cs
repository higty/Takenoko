using System;

namespace Chapter_0016
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Person();
            p.Name = "鈴木";
            p.Age = 22;
            p.OrganizationName = "営業部";
            p.PositionName = "なし";

            var text = CreateText(p);
            Console.WriteLine(text);

            var text1 = p.CreateText();
            Console.WriteLine(text1);

            var text2 = Person.CreateText1(p);
            Console.WriteLine(text2);

            Console.WriteLine("Enter Key...");
            Console.ReadLine();
        }
        static String CreateText(Person person)
        {
            var text = "名前:" + person.Name + Environment.NewLine;
            text += "年齢:" + person.Age + Environment.NewLine;
            text += "組織:" + person.OrganizationName + Environment.NewLine;
            text += "役職:" + person.PositionName + Environment.NewLine;

            //Return value
            return text;
        }
    }
}
