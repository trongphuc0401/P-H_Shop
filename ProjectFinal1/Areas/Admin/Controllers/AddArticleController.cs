using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectFinal1.Models;

namespace ProjectFinal1.Areas.Admin.Controllers
{
    public class AddArticleController : Controller
    {
        // GET: Admin/AddArticle
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddArticle(ARTICLE model)
        {
            MEN_FASHIONSEntities db = new MEN_FASHIONSEntities();
            if (string.IsNullOrEmpty(model.NAME_AR))
            {
                ModelState.AddModelError("", "You need enter the post title");
                return View(model);
            }
            try
            {

                db.ARTICLES.Add(model);
                db.SaveChanges();

                return RedirectToAction("ListArticle");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(model);
            }
        }
    }
}