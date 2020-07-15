using System;

namespace Chapter_0011
{
    class Program
    {
        static void Main(string[] args)
        {
            var xYear = 0;
            while (true)
            {
                Console.WriteLine("年は何ですか？");
                var line = Console.ReadLine();
                if (Int32.TryParse(line, out xYear))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("数字を入力してください。");
                }
            }

            var xMonth = 0;
            while (true)
            {
                Console.WriteLine("月は何ですか？");
                var line = Console.ReadLine();
                if (Int32.TryParse(line, out xMonth))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("数字を入力してください。");
                }
            }

            var xDay = 0;
            while (true)
            {
                Console.WriteLine("日は何ですか？");
                var line = Console.ReadLine();
                if (Int32.TryParse(line, out xDay))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("数字を入力してください。");
                }
            }

            var inputDate = new DateTime(xYear, xMonth, xDay);
            var today = DateTime.Today;
            var ts = today - inputDate;

            Console.WriteLine(ts.TotalDays.ToString() + "日です。");

            Console.ReadLine();
        }
    }
}
