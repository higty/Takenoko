using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_Blog.Views.Blog.Controllers
{
    public class BlogController : Controller
    {
        [HttpGet("/")]
        public IActionResult Root()
        {
            return View();
        }
        [HttpGet("/Login")]
        public IActionResult Login()
        {
            return View();
        }
    }
}
