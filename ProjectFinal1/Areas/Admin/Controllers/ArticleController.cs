using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectFinal1.Models;

namespace ProjectFinal1.Areas.Admin.Controllers
{
    public class ArticleController : Controller
    {
        // GET: Admin/ListArticle
        public ActionResult ListArticle()
        {
            MEN_FASHIONSEntities db = new MEN_FASHIONSEntities();
            return View(db.ARTICLES.ToList());
        }

        //Post
        /// <summary>
        /// Add Article
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult AddArticle()
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
            catch(Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(model);
            }
        }
    }
}