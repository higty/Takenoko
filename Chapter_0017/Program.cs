using System;

namespace Chapter_0017
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Person();
            p.Name = "鈴木";
            p.Age = 23;
            p.OrganizationName = "営業部";
            var text = p.CreateText();

            Console.WriteLine(text);

            Console.WriteLine("EnterKeyを入力");
            Console.ReadLine();
        }
    }
}
