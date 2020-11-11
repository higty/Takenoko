using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Chapter_0019
{
    class Program
    {
        private static String _ConnectionString = "";

        static void Main(string[] args)
        {
            ShowColumnValueList_En("MFoodCategory", "CategoryName");
        }
        private static void ShowColumnValueList_En(String tableName, String columnName)
        {
            var columnValueList = GetRecordValueList("select * from " + tableName, columnName);
            foreach (var columnValue in columnValueList)
            {
                Console.WriteLine(columnValue);
            }

            Console.WriteLine();
            Console.WriteLine("Press Enter...");
            Console.ReadLine();
            Console.WriteLine();
        }
        private static void ShowColumnValueList_Ja(String tableName, String columnName)
        {
            var columnValueList = GetRecordValueList("select * from " + tableName, columnName);
            foreach (var columnValue in columnValueList)
            {
                Console.WriteLine("列の値＝" + columnValue);
            }

            Console.WriteLine();
            Console.WriteLine("エンターキーで終了します。");
            Console.ReadLine();
            Console.WriteLine();
        }
        private static List<String> GetRecordValueList(String query, String columnName)
        {
            var l = new List<String>();

            using (var cn = new SqlConnection(_ConnectionString))
            {
                var cm = new SqlCommand(query);
                cm.Connection = cn;

                cn.Open();
                var dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    var columnValue = dr[columnName].ToString();
                    l.Add(columnValue);
                }
            }
            return l;
        }


        private static void ExecuteSQL(String query)
        {
            using (var cn = new SqlConnection(_ConnectionString))
            {
                var cm = new SqlCommand();
                cm.CommandText = query;

                cn.Open();
                cm.Connection = cn;
                cm.ExecuteNonQuery();
                cn.Close();
            }
        }
        private static void CreateMBlogUserTable()
        {
            ExecuteSQL(@"CREATE Table MBlogUser
(UserCD UNIQUEIDENTIFIER Not NULL
,DisplayName NVARCHAR(64) Not Null
,CreateTime DateTimeOffset(7) Not NULL

,CONSTRAINT MBlogUser_PrimaryKey PRIMARY KEY CLUSTERED(UserCD)
)
");
        }
        private static void CreateDBlogTable()
        {
            ExecuteSQL(@"CREATE TABLE DBlog
(BlogCD UNIQUEIDENTIFIER Not NULL
,Title Nvarchar(128) Not NULL
,CreateTime DateTimeOffset(7) Not NULL
,UserCD UNIQUEIDENTIFIER Not Null
,BodyText NVARCHAR(max) Not NULL

,CONSTRAINT DBlog_PrimaryKey PRIMARY KEY CLUSTERED(BlogCD)
,CONSTRAINT DBlog_FK_UserCD FOREIGN KEY (UserCD) REFERENCES MBlogUser(UserCD)
)
");
        }
        private static void InsertMBlogUserRecords()
        {
            ExecuteSQL("INSERT INTO MBlogUser VALUES(NEWID(), '田中美幸', GETDATE())");
            ExecuteSQL("INSERT INTO MBlogUser VALUES(NEWID(), '高橋紘一', GETDATE())");
            ExecuteSQL("INSERT INTO MBlogUser VALUES(NEWID(), '太田幸子', GETDATE())");
        }
    }
}
