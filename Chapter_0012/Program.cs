using System;
using System.Xml.Schema;

namespace Chapter_0012
{
    class Program
    {
        static void Main(string[] args)
        {
            var y = GetInputAsNumber("年は何ですか？");
            var m = GetInputAsNumber("月は何ですか？");
            var d = GetInputAsNumber("日は何ですか？");

            var inputDate = new DateTime(y, m, d);
            var today = DateTime.Today;
            var ts = today - inputDate;

            Console.WriteLine(ts.TotalDays.ToString() + "日です。");

            Console.ReadLine();
        }
        private static Int32 GetInputAsNumber(String questionText)
        {
            var number = 0;
            while (true)
            {
                Console.WriteLine(questionText);
                var line = Console.ReadLine();
                if (Int32.TryParse(line, out number))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("数字を入力してください。");
                }
            }
            return number;
        }
    }
}
