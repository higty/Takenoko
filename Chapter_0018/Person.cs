using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_0018
{
    public class Person
    {
        private String _Name = "";
        private Int32 _Age = 0;

        public String Name
        {
            get { return _Name; }
            set
            {
                if (value.Length > 10)
                {
                    _Name = value.Substring(0, 10);
                }
                else
                {
                    _Name = value;
                }
            }
        }
        public Int32 Age
        {
            get { return _Age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                _Age = value;
            }
        }

        public Person(String name, Int32 age)
        {
            this.Name = name;
            this.Age = age;
        }

        public String CreateText()
        {
            return this.Name + ": " + this.Age + "才";
        }
    }
}
