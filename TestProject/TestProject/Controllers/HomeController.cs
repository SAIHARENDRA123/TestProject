﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestProject.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
         public ActionResult Home()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
         public ActionResult Register()
        {
            return View();
        }

    }
}
