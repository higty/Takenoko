using System;
using System.ComponentModel;
using System.IO;

namespace Chapter_0004
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = 0;
            while (true)
            {
                Console.WriteLine("好きな食べ物は何でしょう？1.たこ焼き 2.ピザ 3.オムライス 4.タコライス 5.リゾット");
                String text = Console.ReadLine();
                if (text == "3")
                {
                    Console.WriteLine("正解！！！");
                    break;
                }
                else
                {
                    Console.WriteLine("不正解...");
                    count = count + 1;
                }
            }
            var point = 100 - (25 * count);
            if (point < 0)
            {
                point = 0;
            }
            Console.WriteLine("あなたの点数は" + point + "点です");

            Console.WriteLine("enterキーで終了します。");
            Console.ReadLine();
        }
    }
}
