using Newtonsoft.Json;
using System;
using System.IO;

namespace Chapter_0024
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new MySnsConfig();
            c.ConnectionString = "my connection";
            var json = JsonConvert.SerializeObject(c);
            Console.WriteLine(json);
            Console.ReadLine();

            File.WriteAllText("C:\\Dev\\MySnsConfig.json", json);
        }
    }
}
