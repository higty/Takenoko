using System;
using System.Linq.Expressions;

namespace Chapter_0005
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberList = new Int32[3];
            numberList[0] = 2;
            numberList[1] = 3;
            numberList[2] = 5;

            //コップの数だけ繰り返し処理
            for (int i = 0; i < numberList.Length; i++)
            {
                Console.WriteLine("たけのこの数は" + numberList[i]);
            }
            Console.ReadLine();
        }
    }
}
