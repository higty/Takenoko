using System;

namespace Chapter_0007
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowTakenokoList();
        }
        private static void ShowTakenokoList()
        {
            var numberList = new Int32[5];
            numberList[0] = 3;
            numberList[1] = 7;
            numberList[2] = 8;
            numberList[3] = 10;
            numberList[4] = 12;

            for (int i = 0; i < numberList.Length; i++)
            {
                Console.WriteLine("たけのこの数は" + numberList[i] + "です。");
            }
            Console.ReadLine();
        }
        private static void ShowKinokoList()
        {
            var numberList = new Int32[3];
            numberList[0] = 2;
            numberList[1] = 3;
            numberList[2] = 5;

            for (int i = 0; i < numberList.Length; i++)
            {
                Console.WriteLine("きのこの数は" + numberList[i] + "です。");
            }
            Console.ReadLine();
        }
        private static void ShowKoaraList()
        {
            var numberList = new Int32[3];
            numberList[0] = 3;
            numberList[1] = 1;
            numberList[2] = 5;
            for (int i = 0; i < numberList.Length; i++)
            {
                Console.WriteLine("コアラのマーチは" + numberList[i] + "です。");
            }
            Console.ReadLine();
        }
    }
}
