using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_0016
{
    class Person
    {
        public String Name;
        public Int32 Age;
        public String OrganizationName;
        public String PositionName;

        public String CreateText()
        {
            var text = "名前:" + this.Name + Environment.NewLine;
            text += "年齢:" + this.Age + Environment.NewLine;
            text += "組織:" + this.OrganizationName + Environment.NewLine;
            text += "役職:" + this.PositionName + Environment.NewLine;
            return text;
        }
        public static String CreateText1(Person person)
        {
            var text = person.Name + ": " + person.Age;
            return text;
        }
    }
}
