using System;
using System.Diagnostics;

namespace Chapter_0015
{
    class Program
    {
        static void Main(string[] args)
        {
            var phoneNumber = "０９０－４５６１－２３７８";

            var sw = Stopwatch.StartNew();
            var s1 = ToHalfWidth(phoneNumber);
            sw.Stop();
            var ts = sw.Elapsed;
            Console.WriteLine(ts.TotalMilliseconds.ToString() + "ミリ秒です");

            Console.WriteLine(s1);

            Console.WriteLine("Enterキーで終了");
            Console.ReadLine();
        }

        static String ToHalfWidth(String value)
        {
            var s = value.Replace("０", "0");
            s = s.Replace("１", "1");
            s = s.Replace("２", "2");
            s = s.Replace("３", "3");
            s = s.Replace("４", "4");
            s = s.Replace("５", "5");
            s = s.Replace("６", "6");
            s = s.Replace("７", "7");
            s = s.Replace("８", "8");
            s = s.Replace("９", "9");
            s = s.Replace("－", "-");

            return s;
        }

        static String ToHalfWidth_HighPerformance(String value)
        {
            var cc = new Char[value.Length];
            //０:65296  0:48
            for (int i = 0; i < value.Length; i++)
            {
                var c = value[i];
                if (c == '－')
                {
                    cc[i] = '-';
                }
                else
                {
                    var newChar = (Char)((Int32)c - 65248);
                    cc[i] = newChar;
                }
            }
            return new String(cc);
        }
    }
}
