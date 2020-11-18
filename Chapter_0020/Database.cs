using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Takenoko.Data
{
    public class Database
    {
        public String ConnectionString { get; set; }

        public void ExecuteSQL(String query)
        {
            using (var cn = new SqlConnection(this.ConnectionString))
            {
                var cm = new SqlCommand();
                cm.CommandText = query;

                cn.Open();
                cm.Connection = cn;
                cm.ExecuteNonQuery();
                cn.Close();
            }
        }
        public void MBlogUser_Insert(String displayName)
        {
            var sql = String.Format("INSERT INTO MBlogUser VALUES(NEWID(), '{0}', GETDATE())", displayName);
            this.ExecuteSQL(sql);
        }
        public void DBlog_Insert(String title, Guid userCD, String bodyText)
        {
            var sql = String.Format("INSERT DBlog VALUES(NEWID(),'{0}', GETDATE(), '{1}', '{2}')"
                , title, userCD, bodyText);
            this.ExecuteSQL(sql);
        }
        public List<DBlogRecord> DBlog_List_Get()
        {
            var l = new List<DBlogRecord>();

            using (var cn = new SqlConnection(this.ConnectionString))
            {
                var cm = new SqlCommand("select * from DBlog");
                cm.Connection = cn;

                cn.Open();
                var dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    var r = new DBlogRecord();
                    this.SetProperty(r, dr);
                    l.Add(r);
                }
            }
            return l;
        }
        public List<DBlogRecord> DBlog_List_Get_By_Date(DateTime date)
        {
            var l = new List<DBlogRecord>();

            using (var cn = new SqlConnection(this.ConnectionString))
            {
                var sql = String.Format("select * from DBlog where '{0}' <= CreateTime and CreateTime < '{1}'"
                    , date.ToString("yyyy/MM/dd 00:00"), date.AddDays(1).ToString("yyyy/MM/dd 00:00"));
                var cm = new SqlCommand(sql);
                cm.Connection = cn;

                cn.Open();
                var dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    var r = new DBlogRecord();
                    this.SetProperty(r, dr);
                    l.Add(r);
                }
            }
            return l;
        }
        public List<DBlogRecord> DBlog_List_Get_By_Title(String title)
        {
            var l = new List<DBlogRecord>();

            using (var cn = new SqlConnection(this.ConnectionString))
            {
                var sql = String.Format("select * from DBlog where Title = '{0}'", title);
                var cm = new SqlCommand(sql);
                cm.Connection = cn;

                cn.Open();
                var dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    var r = new DBlogRecord();
                    this.SetProperty(r, dr);
                    l.Add(r);
                }
            }
            return l;
        }
        private void SetProperty(DBlogRecord record, SqlDataReader reader)
        {
            var r = record;
            var dr = reader;

            r.BlogCD = (Guid)dr["BlogCD"];
            r.Title = dr["Title"].ToString();
            r.CreateTime = (DateTimeOffset)dr["CreateTime"];
            r.UserCD = (Guid)dr["UserCD"];
            r.BdoyText = dr["BodyText"].ToString();
        }
    }
}
