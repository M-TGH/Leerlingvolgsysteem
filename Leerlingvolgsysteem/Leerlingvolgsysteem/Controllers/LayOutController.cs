using Leerlingvolgsysteem.Models.Services.AccountServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Leerlingvolgsysteem.Controllers
{
    public class LayOutController : Controller
    {
        AccountService AccountService = new AccountService();
        // GET: LayOut
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult HeaderPartial()
        { 
            if (Session["UserId"] != null || (int)Session["UserId"] < 1)
            {
                var output = AccountService.ShowProfile((int)Session["UserId"]);
                return PartialView(output);
            }
            else
            {
                return RedirectToAction("Login", "Account");
            }
        }
    }
}