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
                cm.CommandText = "insert into [User](UserCD,DisplayName,ID,Password,Twitter,Facebook,Instagram,Youtube)"
                    + "values(@UserCD,@DisplayName,@ID,@Password,@Twitter,@Facebook,@Instagram,@Youtube)";
                cm.Parameters.AddWithValue("@UserCD", Guid.NewGuid());
                cm.Parameters.AddWithValue("@DisplayName", rUser.DisplayName);
                cm.Parameters.AddWithValue("@ID", rUser.ID);
                cm.Parameters.AddWithValue("@Password", rUser.Password);
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

        [HttpGet("/Login")]
        public IActionResult Login()
        {
            return this.View();
        }

        public class LoginParameter
        {
            public String UserID { get; set; }
            public String Password { get; set; }
        }
        [HttpPost("/Api/Login")]
        public async Task<Object> Api_Login()
        {
            var json = await GetRequestBodyText();
            var p = JsonConvert.DeserializeObject<LoginParameter>(json);
            var rUser = this.GetUser(p.UserID);
            if (rUser != null && rUser.Password == p.Password)
            {
                HttpContext.Response.Cookies.Append("UserCD", rUser.UserCD.ToString());
                //ログイン成功
                var result = new LoginResult();
                result.Success = true;
                result.Url = "/Profile/" + rUser.ID;
                return result;
            }
            else
            {
                //パスワードが違いますというメッセージを表示
                var result = new LoginResult();
                result.Success = false;
                result.Message = "パスワードが違います！";
                return result;
            }
        }
        public class LoginResult
        {
            public Boolean Success { get; set; }
            public String Url { get; set; }
            public String Message { get; set; }
        }


        [HttpGet("/Profile/{id}")]
        public IActionResult Profile(String id)
        {
            var model = this.GetUser(id);
            return this.View(model);
        }
        private UserRecord GetUser(String id)
        {
            var db = new SqlServerDatabase(WebApp.Current.Config.ConnectionString);
            var cm = new SqlCommand();
            cm.CommandText = "select * from [User] where ID = @ID";
            cm.Parameters.AddWithValue("@ID", id);
            var dr = db.ExecuteReader(cm);

            while (dr.Read())
            {
                var rUser = new UserRecord();
                rUser.DisplayName = dr["DisplayName"].ToString();
                rUser.ID = id;
                rUser.Password = dr["Password"].ToString();
                rUser.Twitter = dr["Twitter"].ToString();
                rUser.Facebook = dr["Facebook"].ToString();
                rUser.Instagram = dr["Instagram"].ToString();
                rUser.Youtube = dr["Youtube"].ToString();

                return rUser;
            }
            return null;
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

        [HttpGet("/Cookie")]
        public IActionResult Cookie()
        {
            if (HttpContext.Request.Cookies.TryGetValue("UserCD", out var userCD))
            {
                //Get cookie value
            }
            HttpContext.Response.Cookies.Append("UserCD", "77");
            HttpContext.Response.Cookies.Append("UserName", "mary");
            return this.View();
        }
        [HttpGet("/ClearCookie")]
        public IActionResult ClearCookie()
        {
            var option = new CookieOptions();
            option.Expires = new DateTimeOffset(2000, 1, 1, 0, 0, 0, TimeSpan.FromSeconds(0));
            HttpContext.Response.Cookies.Append("UserCD", "77", option);
            HttpContext.Response.Cookies.Append("UserName", "mary", option);
            return this.View();
        }
        [HttpGet("/Sample1")]
        public IActionResult Sample1()
        {
            return this.View();
        }
    }
}
