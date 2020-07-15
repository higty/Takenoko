using System;

namespace Chapter_0010
{
    class Program
    {
        static void Main(string[] args)
        {
            //整数（正数負数両方）
            Byte x8 = 2;
            Int16 x16 = 1;
            Int32 x32 = 1;
            Int64 x64 = 22;
            //正数
            UInt16 u16 = 33;

            //型の推論（C#3.0から）
            var x = 25;

            //小数（精度の違い）
            Single single1 = 3.5f;
            Double double1 = 3.5;
            
            //小数（正確な計算が可能）
            Decimal m1 = 3.5m;

            //文字
            String s = "Hello";
            var s1 = "Hello";
            //1文字
            Char c1 = '美';
            var c2 = s[2];
            var c3 = 'a';

            //Boolean型
            Boolean b1 = true;

            var line = Console.ReadLine();
            var answerIsOne = line == "1";
            var lineIs2 = line == "2";
            var lineIsHello = line == "Hello";
            //演算子(+, -, *, =, == ....)
            //値 演算子 値 ---> 一つの値

            //DateTime型
            var d4 = new DateTime(2000, 4, 1);
            Console.WriteLine(d4);
            var d5 = DateTime.Now;
            Console.WriteLine(d5);

            //TimeSpan型。期間を表す
            TimeSpan ts = d5 - d4;
            Console.WriteLine(ts.TotalDays.ToString());

            var d7 = d5 + TimeSpan.FromHours(500);
            Console.WriteLine(d7.ToString());
            Console.ReadLine();

        }
    }
}
