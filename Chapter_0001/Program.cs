using Microsoft.VisualBasic;
using System;
using System.Numerics;
using System.Threading;

namespace Chapter_0001
{
    class Program
    {
        static void Main(string[] args)
        {
            var number1 = Console.ReadLine();
            var x1 = 0;

            while (true)
            {
                if (Int32.TryParse(number1, out x1) == true)
                {
                    break;
                }
                Console.WriteLine("数字を入力してください。");
                number1 = Console.ReadLine();
            }

            var number2 = Console.ReadLine();
            var x2 = 0;
            while (true)
            {
                if (Int32.TryParse(number2, out x2) == true)
                {
                    break;
                }
                Console.WriteLine("数字を入力してください。");
                number2 = Console.ReadLine();
            }

            var result = x1 * x2;
            Console.WriteLine(result);
        }
        static void Caluculate_CharCount()
        {
            var line = Console.ReadLine();
            var charCount = line.Length;
            Console.WriteLine(charCount + "文字です");
        }
    }
}
