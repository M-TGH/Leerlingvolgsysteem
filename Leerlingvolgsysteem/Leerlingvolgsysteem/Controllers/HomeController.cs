using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Leerlingvolgsysteem.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Mail()
        {
            return View();
        }
        public ActionResult Messages()
        {
            return View();
        }
    }
}