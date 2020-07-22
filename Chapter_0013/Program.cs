using System;
using System.IO;
using System.Text;

namespace Chapter_0013
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadCsvAndCreateNewListCsv();
        }
        private static void CreateCsvFile()
        {
            EncodingProvider provider = System.Text.CodePagesEncodingProvider.Instance;
            var encoding = provider.GetEncoding(932);

            var body = "名前,年齢,性別,学部,役職";
            body = body + Environment.NewLine + "新井,19,女,文学部,なし";
            body = body + Environment.NewLine + "森内,22,男,法学部,部長";

            System.IO.File.WriteAllText("C:\\Data\\NewMemberList.csv", body, encoding);
            Console.WriteLine("保存しました！");

            Console.WriteLine("Enterキーで終了します。");
            Console.ReadLine();
        }
        private static void ReadCsvAndCreateNameListCsv()
        {
            EncodingProvider provider = System.Text.CodePagesEncodingProvider.Instance;
            var encoding = provider.GetEncoding(932);

            var body = System.IO.File.ReadAllText("C:\\Data\\MemberList.csv", encoding);

            var sr = new StringReader(body);
            var nameList = new String[14];
            var index = 0;
            while (sr.Peek() > -1)
            {
                var line = sr.ReadLine();
                if (index == 0)
                {
                    index = index + 1;
                    continue;
                }
                var nameCount = line.IndexOf(',');
                nameList[index - 1] = line.Substring(0, nameCount);
                index = index + 1;
                Console.WriteLine(line);
            }
            var newBody = "";
            for (int i = 0; i < nameList.Length; i++)
            {
                newBody = newBody + nameList[i] + Environment.NewLine;
            }
            System.IO.File.WriteAllText("C:\\Data\\NameList.csv", newBody, encoding);

            Console.WriteLine("Enterキーで終了します。");
            Console.ReadLine();

        }
        private static void ReadCsvAndCreateNewListCsv()
        {
            EncodingProvider provider = System.Text.CodePagesEncodingProvider.Instance;
            var encoding = provider.GetEncoding(932);

            var body = System.IO.File.ReadAllText("C:\\Data\\MemberList.csv", encoding);

            var sr = new StringReader(body);
            var nameList = new String[14];
            var gakubuList = new String[14];
            var isFirstRow = true;
            var index = 0;
            while (sr.Peek() > -1)
            {
                var line = sr.ReadLine();
                if (isFirstRow == true)
                {
                    isFirstRow = false;
                    continue;
                }

                var ss = line.Split(',');
                nameList[index] = ss[0];
                gakubuList[index] = ss[3];
                index = index + 1;
                Console.WriteLine(line);
            }
            var newBody = "";
            for (int i = 0; i < nameList.Length; i++)
            {
                newBody = newBody + nameList[i] + "," + gakubuList[i] + Environment.NewLine;
            }
            System.IO.File.WriteAllText("C:\\Data\\NameAndGakubuList.csv", newBody, encoding);

            Console.WriteLine("Enterキーで終了します。");
            Console.ReadLine();

        }
    }
}
