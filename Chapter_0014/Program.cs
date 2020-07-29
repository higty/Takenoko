using System;
using System.IO;

namespace Chapter_0014
{
    class Program
    {
        static void Main(string[] args)
        {
            Sample_Contains();
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
        static void Sample_Insert()
        {
            var body = File.ReadAllText("C:\\Data\\String_Study.txt");
            var ss = body.Split(' ');

            for (int i = 0; i < ss.Length; i++)
            {
                Console.WriteLine(ss[i].Insert(1, "_"));
            }
            Console.WriteLine("Enterキーで終了");
            Console.ReadLine();
        }
        static void Sample_LastIndexOf()
        {
            var body = File.ReadAllText("C:\\Data\\String_Study.txt");
            var ss = body.Split(' ');

            for (int i = 0; i < ss.Length; i++)
            {
                var index = ss[i].LastIndexOf("e");
                if (index == -1) { continue; }
                Console.WriteLine(ss[i] + " " + (index + 1) + "文字目");
            }
            Console.WriteLine("Enterキーで終了");
            Console.ReadLine();
        }
        static void Sample_Length()
        {
            var body = File.ReadAllText("C:\\Data\\String_Study.txt");
            var ss = body.Split(' ');

            for (int i = 0; i < ss.Length; i++)
            {
                Console.WriteLine(ss[i] + " " + (ss[i].Length) + "文字です。");
            }
            Console.WriteLine("Enterキーで終了");
            Console.ReadLine();
        }
        static void Sample_PadLeft()
        {
            for (int i = 0; i < 100; i++)
            {
                var number = i.ToString();
                number = number.PadLeft(6, '0');
                Console.WriteLine(number);
            }
            Console.WriteLine("Enterキーで終了");
            Console.ReadLine();
        }
        static void Sample_Remove()
        {
            var body = File.ReadAllText("C:\\Data\\String_Study.txt");
            var ss = body.Split(' ');
            var count = 0;

            for (int i = 0; i < ss.Length; i++)
            {
                if (ss[i].Length < 2) { continue; }
                var removedText = ss[i].Remove(0, 2);
                Console.WriteLine(ss[i] + "-->" + removedText);
            }
            Console.WriteLine(count + "単語ありました！！！");

            Console.WriteLine("Enterキーで終了");
            Console.ReadLine();
        }
        static void Sample_Replace()
        {
            var body = File.ReadAllText("C:\\Data\\String_Study.txt");
            var ss = body.Split(' ');
            var count = 0;

            for (int i = 0; i < ss.Length; i++)
            {
                var replaceText = ss[i].Replace("a", "美").Replace("e", "鮮").Replace("n", "光").Replace("i", "愛");
                Console.WriteLine(ss[i] + "-->" + replaceText);
            }
            Console.WriteLine(count + "単語ありました！！！");

            Console.WriteLine("Enterキーで終了");
            Console.ReadLine();

        }
        static void Sample_Substring()
        {
            var body = File.ReadAllText("C:\\Data\\String_Study.txt");
            var ss = body.Split(' ');
            var count = 0;

            for (int i = 0; i < ss.Length; i++)
            {
                if (ss[i].Length < 3) { continue; }
                Console.WriteLine(ss[i] + "-->" + ss[i].Substring(0, 3));
            }
            Console.WriteLine(count + "単語ありました！！！");

            Console.WriteLine("Enterキーで終了");
            Console.ReadLine();

        }
        static void Sample_Lower_Upper()
        {
            var body = File.ReadAllText("C:\\Data\\String_Study.txt");
            var ss = body.Split(' ');
            var count = 0;

            for (int i = 0; i < ss.Length; i++)
            {
                Console.WriteLine(ss[i] + "-->" + ss[i].ToLower());
                Console.WriteLine(ss[i] + "-->" + ss[i].ToUpper());
            }
            Console.WriteLine(count + "単語ありました！！！");

            Console.WriteLine("Enterキーで終了");
            Console.ReadLine();

        }
    }
}
