using System;
using System.Text;

namespace Chapter_0013
{
    class Program
    {
        static void Main(string[] args)
        {
            EncodingProvider provider = System.Text.CodePagesEncodingProvider.Instance;
            var encoding = provider.GetEncoding(932);

            var body = "名前,年齢,性別,学部,役職";
            body = body + Environment.NewLine + "新井,19,女,文学部,なし";

            System.IO.File.WriteAllText("C:\\Data\\NewMemberList.csv", body, encoding);
            Console.WriteLine("保存しました！");

            Console.WriteLine("Enterキーで終了します。");
            Console.ReadLine();
        }
    }
}
