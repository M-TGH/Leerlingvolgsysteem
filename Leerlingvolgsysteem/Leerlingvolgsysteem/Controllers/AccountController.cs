using Leerlingvolgsysteem.Models;
using Leerlingvolgsysteem.Models.Services;
using Leerlingvolgsysteem.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Leerlingvolgsysteem.Controllers
{
    public class AccountController : Controller
    {
        LoginService LoginUserService = new LoginService();
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(AccountLoginViewModel AccountData)
        {
            if (ModelState.IsValid)
            {
                var Loginstatus = LoginUserService.LoginAccount(AccountData);
                if(Loginstatus.Error != true)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return View(Loginstatus);
                }
            }
            return View();
        }
    }
}