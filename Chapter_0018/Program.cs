using System;
using System.Runtime.InteropServices;

namespace Chapter_0018
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Person("田中0123456789", -10);

            var text = p.CreateText();
            Console.WriteLine(text);

            Console.WriteLine("Enter Keyで終了");
            Console.ReadLine();

        }
    }
}
