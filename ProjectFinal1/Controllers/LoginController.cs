using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectFinal1.Models;
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
            MEN_FASHIONSEntities db =new MEN_FASHIONSEntities();
            ACCOUNT acc = new MEN_FASHIONSEntities().ACCOUNTs.Where(x => x.ACCOUNT1.Equals(Acc.ToLower().Trim()) && x.PASS.Equals(Pass)).FirstOrDefault<ACCOUNT>();
            bool isAuthentic = acc != null && acc.ACCOUNT1.Equals(Acc.ToLower().Trim()) && acc.PASS.Equals(Pass);

            if (isAuthentic)
            {
                Session["Login"] = acc;
                return RedirectToAction("Index", "Dashboard", new { Areas = "Admin" });
            }
            return View();
        }
    }
}