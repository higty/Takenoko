using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HigLabo.Data;
using Newtonsoft.Json;
using System.Data.SqlClient;

namespace WebAppMySns.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public IActionResult Root()
        {
            var model = new RootPage();
            var db = new SqlServerDatabase(WebApp.Current.Config.ConnectionString);
            var cm = new SqlCommand();
            cm.CommandText = "select * from [User]";
            var dr = db.ExecuteReader(cm);

            while (dr.Read())
            {
                var r = new UserRecord();
                r.DisplayName = dr["DisplayName"].ToString();
                r.ID = dr["ID"].ToString();
                r.Twitter = dr["Twitter"].ToString();
                r.Facebook = dr["Facebook"].ToString();
                r.Instagram = dr["Instagram"].ToString();
                r.Youtube = dr["Youtube"].ToString();
                model.UserList.Add(r);
            }
            return this.View(model);
        }
        public class RootPage
        {
            public List<UserRecord> UserList { get; private set; } = new List<UserRecord>();
        }

        [HttpGet("/Signup")]
        public IActionResult Signup()
        {
            return this.View();
        }
        [HttpPost("/Api/Signup")]
        public async Task<Object> Api_Signup()
        {
            var json = await GetRequestBodyText();
            var rUser = JsonConvert.DeserializeObject<UserRecord>(json);

            //DBにユーザーを登録する
            try
            {
                var db = new SqlServerDatabase(WebApp.Current.Config.ConnectionString);
                var cm = new SqlCommand();
                cm.CommandText = "insert into [User](UserCD,DisplayName,ID,Twitter,Facebook,Instagram,Youtube)"
                    + "values(@UserCD,@DisplayName,@ID,@Twitter,@Facebook,@Instagram,@Youtube)";
                cm.Parameters.AddWithValue("@UserCD", Guid.NewGuid());
                cm.Parameters.AddWithValue("@DisplayName", rUser.DisplayName);
                cm.Parameters.AddWithValue("@ID", rUser.ID);
                cm.Parameters.AddWithValue("@Twitter", rUser.Twitter);
                cm.Parameters.AddWithValue("@Facebook", rUser.Facebook);
                cm.Parameters.AddWithValue("@Instagram", rUser.Instagram);
                cm.Parameters.AddWithValue("@Youtube", rUser.Youtube);

                var insertCount = db.ExecuteCommand(cm);
                return "実行完了！";
            }
            catch (Exception ex) when (ex.Message.Contains("User_Uk_ID") == true)
            {
                return "IDが重複しているよ！";
            }
        }
        private async Task<String> GetRequestBodyText()
        {
            Request.EnableBuffering();
            Request.Body.Position = 0;
            var m = new MemoryStream();
            await Request.Body.CopyToAsync(m);
            var bb = m.ToArray();
            var text = Encoding.UTF8.GetString(bb);
            return text;
        }

        [HttpGet("/Profile/{id}")]
        public IActionResult Profile(String id)
        {
            //DBから取得してセット
            var db = new SqlServerDatabase(WebApp.Current.Config.ConnectionString);
            var cm = new SqlCommand();
            cm.CommandText = "select * from [User] where ID = @ID";
            cm.Parameters.AddWithValue("@ID", id);
            var dr = db.ExecuteReader(cm);

            var model = new UserRecord();
            while (dr.Read())
            {
                model.DisplayName = dr["DisplayName"].ToString();
                model.ID = id;
                model.Twitter = dr["Twitter"].ToString();
                model.Facebook = dr["Facebook"].ToString();
                model.Instagram = dr["Instagram"].ToString();
                model.Youtube = dr["Youtube"].ToString();
            }
            return this.View(model);
        }

        [HttpGet("/Slime")]
        public IActionResult Slime()
        {
            return this.View();
        }
        [HttpGet("/HtmlElementQueryPage")]
        public IActionResult HtmlElementQueryPage()
        {
            return this.View();
        }

        [HttpGet("/Sample1")]
        public IActionResult Sample1()
        {
            return this.View();
        }
    }
}
