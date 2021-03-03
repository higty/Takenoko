using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAppMySns.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public IActionResult Root()
        {
            return this.View();
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

            return "実行完了！";
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
