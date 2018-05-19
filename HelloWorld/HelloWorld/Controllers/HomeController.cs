using HelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.WelcomeString = "Chào mừng bạn đến với ViewBag";

            var message = new MessageModel();
            message.Welcome = "Chào mừng đến với Models";
            return View(message);
        }
    }
}