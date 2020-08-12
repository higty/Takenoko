using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_0017
{
    public class Person
    {
        private String _Name = "名前無し";
        private Int32 _Age;

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
            get
            {
                return _Age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("value is invalid. value must be greater than or equal 0.");
                }
                _Age = value;
            }
        }
        public String OrganizationName { get; set; }

        public String CreateText()
        {
            return this.Name + ": " + this.Age + "才 (" + this.OrganizationName + ")";
        }
    }
}
