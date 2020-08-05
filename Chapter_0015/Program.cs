using System;
using System.Diagnostics;

namespace Chapter_0015
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "田中";
            var age = 30;
            var positionName = "課長";
            var birthDay = new DateTime(1990, 2, 2);
            var organizationName = "IT部";
            var workPlace = "東京";

            var text = CreatePersonInfoText(name, age, positionName, birthDay, organizationName, workPlace);
            Console.WriteLine(text);


            var p = new Person();
            p.Name = "鈴木";
            p.Age = 32;
            p.PositionName = "次長";
            p.Birthday = new DateTime(1989, 6, 9);
            p.OrganizationName = "企画部";
            p.Workplace = "東京";
            var text1 = CreatePersonInfoText(p);
            Console.WriteLine(text1);

            var p1 = new Person();
            p1.Name = "福田";
            p1.Age = 38;
            p1.Birthday = new DateTime(1982, 3, 30);
            p1.OrganizationName = "なし";
            p1.Workplace = "新橋";
            var text2 = CreatePersonInfoText(p1);
            Console.WriteLine(text2);


            Console.WriteLine("EnterKeyで終了");
            Console.ReadLine();
        }
        static String CreatePersonInfoText(String name, Int32 age, String positionName, DateTime birthday, String organizationName, String workPlace)
        {
            var text = "名前: " + name + Environment.NewLine;
            text += "年齢: " + age + Environment.NewLine;
            text += "役職: " + positionName + Environment.NewLine;
            text += "誕生日: " + birthday.ToString("yyyy/MM/dd") + Environment.NewLine;
            text += "組織: " + organizationName + Environment.NewLine;
            text += "勤務地: " + workPlace + Environment.NewLine;
            return text;
        }
        static String CreatePersonInfoText_Star(String name, Int32 age, String positionName, DateTime birthday, String organizationName, String workPlace)
        {
            var text = "☆名前: " + name + Environment.NewLine;
            text += "☆年齢: " + age + Environment.NewLine;
            text += "☆役職: " + positionName + Environment.NewLine;
            text += "☆誕生日: " + birthday.ToString("yyyy/MM/dd") + Environment.NewLine;
            text += "☆組織: " + organizationName + Environment.NewLine;
            text += "☆勤務地: " + workPlace + Environment.NewLine;
            return text;
        }
        static String CreatePersonInfoText(Person person)
        {
            var text = "名前: " + person.Name + Environment.NewLine;
            text += "年齢: " + person.Age + Environment.NewLine;
            text += "役職: " + person.PositionName + Environment.NewLine;
            text += "誕生日: " + person.Birthday.ToString("yyyy/MM/dd") + Environment.NewLine;
            text += "組織: " + person.OrganizationName + Environment.NewLine;
            text += "勤務地: " + person.Workplace + Environment.NewLine;
            return text;
        }
    }
}
