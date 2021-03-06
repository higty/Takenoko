﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TakenokoProgramingWebSite.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public IActionResult Root()
        {
            return View();
        }
        [HttpGet("/Image/List")]
        public IActionResult ImageList()
        {
            return View();
        }
        [HttpGet("/Style/Sample")]
        public IActionResult StyleSample()
        {
            return View();
        }
        [HttpGet("/Link/List")]
        public IActionResult LinkList()
        {
            return View();
        }
        [HttpGet("/CheatSheet")]
        public IActionResult CheatSheet()
        {
            return View();
        }
    }
}
