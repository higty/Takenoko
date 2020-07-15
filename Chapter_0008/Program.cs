using System;

namespace Chapter_0008
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberList = new Int32[4];
            numberList[0] = 3;
            numberList[1] = 7;
            numberList[2] = 8;
            numberList[3] = 10;

            //引数。値を引き渡す
            ShowTakenokoList(numberList, "きのこ");

            ShowTakenokoList("たけのこ");
        }
        private static void ShowTakenokoList(Int32[] numberList, String name)
        {
            for (int i = 0; i < numberList.Length; i++)
            {
                Console.WriteLine(name + "の数は" + numberList[i] + "です。");
            }
            Console.ReadLine();
        }
        private static void ShowTakenokoList(String name)
        {
            var numberList = new Int32[4];
            numberList[0] = 3;
            numberList[1] = 7;
            numberList[2] = 8;
            numberList[3] = 5;

            for (int i = 0; i < numberList.Length; i++)
            {
                Console.WriteLine(name + "の数は" + numberList[i] + "です。");
            }
            Console.ReadLine();
        }
    }
}
