using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectFinal1.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(String Acc,string Pass)
        {
            bool isAuthentic = (Acc != null && Pass != null && Acc.ToLower().Equals("admin") && Pass.Equals("123456"));
            if (isAuthentic)
                return View("~/Areas/Admin/Views/Dashboard/Index.cshtml");
            return View();
        }
    }
}