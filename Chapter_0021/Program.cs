using Newtonsoft.Json;
using System;
using System.IO;

namespace Chapter_0021
{
    class Program
    {
        static void Main(string[] args)
        {
            var json = File.ReadAllText("D:\\Data\\Person.txt");

            var p = JsonConvert.DeserializeObject<Person>(json);
        }
        private static void CreateJsonFile()
        {
            var p = new Person();
            p.Name = "田中";
            p.Age = 21;
            p.BodyHeight = 175;

            var json = JsonConvert.SerializeObject(p, Formatting.Indented);

            File.WriteAllText("D:\\Data\\Person.txt", json);
        }
    }

    public class Person
    {
        public String Name { get; set; }
        public Int32 Age { get; set; }
        public Int32 BodyHeight { get; set; }
    }
}
