using System;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;

namespace Chapter_0006
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberList = new Int32[5];
            numberList[0] = 3;
            numberList[1] = 7;
            numberList[2] = 8;
            numberList[3] = 10;
            numberList[4] = 12;

            Console.WriteLine("for");
            for (int i = 0; i < numberList.Length; i++)
            {
                Console.WriteLine("たけのこの数は" + numberList[i] + "です。");
            }

            Console.WriteLine("foreach");
            foreach (var item in numberList)
            {
                Console.WriteLine("たけのこの数は" + item + "です。");               
            }

            Console.WriteLine("while (条件式)");
            var index = 0;
            while (index < numberList.Length)
            {
                Console.WriteLine("たけのこの数は" + numberList[index] + "です。");
                index = index + 1;
            }

            Console.WriteLine("while--break");
            index = 0;
            while (true)
            {
                Console.WriteLine("たけのこの数は" + numberList[index] + "です。");
                index = index + 1;
                if (index == numberList.Length) { break; }
            }
            Console.ReadLine();
        }
    }
}
