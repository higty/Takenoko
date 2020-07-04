using System;

namespace Chapter_0002
{
    class Program
    {
        static void Main(string[] args)
        {
            //0123456789abcdef 16段階
            System.IO.File.WriteAllText("C:\\Data\\MyHomepage.html", "<html><head></head><body>"
                + "<div style=\"width:100%;height:80px;background-color:#f08080;color:#ffffff;\">mediumvioletred</div>"
                + "<div style=\"width:100%;height:80px;background-color:#ff0000\"></div>"
                + "<div style=\"width:100%;height:80px;background-color:#ff8800\"></div>"
                + "<div style=\"width:100%;height:80px;background-color:#ffff00\"></div>"
                + "<div style=\"width:100%;height:80px;background-color:#22dd00\"></div>"
                + "<div style=\"width:100%;height:80px;background-color:#0000cc\"></div>"
                + "<div style=\"width:100%;height:80px;background-color:#cc00cc\"></div>"
                + "<div style=\"width:100%;height:80px;background-color:#ff00aa\"></div>"
                + "</body></html>");
            Console.WriteLine("HTMLファイルができました！");
        }
        static void CreateTextFile()
        {
            System.IO.File.WriteAllText("C:\\Data\\MyFavoriteFoods.txt", "まりの好きな食べ物。フレンチトースト、ハンバーグ、焼き肉。");
        }
    }
}
