using System;
using System.IO;

namespace Chapter_0014
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        static void Sample_Contains()
        {
            var body = File.ReadAllText("C:\\Data\\String_Study.txt");
            var ss = body.Split(' ');
            var count = 0;

            for (int i = 0; i < ss.Length; i++)
            {
                if (ss[i].Contains("a"))
                {
                    Console.WriteLine(ss[i]);
                    count = count + 1;
                }
            }
            Console.WriteLine(count + "単語ありました！！！");

            Console.WriteLine("Enterキーで終了");
            Console.ReadLine();
        }
        static void Sample_StartsWith()
        {
            var body = File.ReadAllText("C:\\Data\\String_Study.txt");
            var ss = body.Split(' ');
            var count = 0;

            for (int i = 0; i < ss.Length; i++)
            {
                if (ss[i].StartsWith("f"))
                {
                    Console.WriteLine(ss[i]);
                    count = count + 1;
                }
            }
            Console.WriteLine(count + "単語ありました！！！");

            Console.WriteLine("Enterキーで終了");
            Console.ReadLine();

        }
        static void Sample_Equals()
        {
            var body = File.ReadAllText("C:\\Data\\String_Study.txt");
            var ss = body.Split(' ');
            var count = 0;

            for (int i = 0; i < ss.Length; i++)
            {
                if (ss[i].Equals("are"))
                {
                    Console.WriteLine(ss[i]);
                    count = count + 1;
                }
            }
            Console.WriteLine(count + "単語ありました！！！");

            Console.WriteLine("Enterキーで終了");
            Console.ReadLine();

        }
        static void Sample_IndexOf()
        {
            var body = File.ReadAllText("C:\\Data\\String_Study.txt");
            var ss = body.Split(' ');

            for (int i = 0; i < ss.Length; i++)
            {
                var index = ss[i].IndexOf('a');
                if (index == -1) { continue; }

                Console.WriteLine("------------------");
                Console.WriteLine(ss[i]);
                Console.WriteLine((index + 1) + "文字目にaがあるよ");
            }

            Console.WriteLine("Enterキーで終了");
            Console.ReadLine();


        }
        static void Sample_IndexOfAny()
        {
            var body = File.ReadAllText("C:\\Data\\String_Study.txt");
            var ss = body.Split(' ');

            for (int i = 0; i < ss.Length; i++)
            {
                var index = ss[i].IndexOfAny(new Char[] { 'x', 'y', 'z' });
                if (index == -1) { continue; }

                Console.WriteLine("------------------");
                Console.WriteLine(ss[i]);
                Console.WriteLine((index + 1) + "文字目にあったよ");
            }

            Console.WriteLine("Enterキーで終了");
            Console.ReadLine();
        }
    }
}
