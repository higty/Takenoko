using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using Takenoko.Data;

namespace Chapter_0020
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new Database();
            db.ConnectionString =  File.ReadAllText("C:\\Data\\ConnectionString.txt");

            foreach (var record in db.DBlog_List_Get_By_Title("立山旅行"))
            {
                Console.WriteLine(String.Format("{0} {1}", record.CreateTime.ToString("yyyy/MM/dd"), record.Title));
            }
            Console.ReadLine();
        }
    }
}

