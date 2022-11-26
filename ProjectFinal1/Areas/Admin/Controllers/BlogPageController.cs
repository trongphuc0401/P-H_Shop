using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectFinal1.Areas.Admin.Controllers
{
    public class BlogPageController : Controller
    {
        // GET: Admin/BlogPage
        public ActionResult Index()
        {
            return View();
        }
    }
}