using System;
using System.Runtime.CompilerServices;

namespace Chapter_0009
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowTakenokoList("きのこ");
        }
        private static void ShowTakenokoList(String name)
        {
            var numberList = GetNumberList_Pattern2();

            for (int i = 0; i < numberList.Length; i++)
            {
                Console.WriteLine(name + "の数は" + numberList[i] + "です。");
            }
            Console.ReadLine();
        }
        private static String ReturnText()
        {
            return "Mari";
        }
        private static Int32[] GetNumberList_Pattern1()
        {
            var numberList = new Int32[3];
            numberList[0] = 3;
            numberList[1] = 5;
            numberList[2] = 7;
            return numberList;
        }
        private static Int32[] GetNumberList_Pattern2()
        {
            var numberList = new Int32[5];
            numberList[0] = 3;
            numberList[1] = 5;
            numberList[2] = 7;
            numberList[3] = 12;
            numberList[4] = 11;
            return numberList;
        }
    }

}
