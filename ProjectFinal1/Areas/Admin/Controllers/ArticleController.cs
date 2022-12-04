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
        private static MEN_FASHIONSEntities database = new MEN_FASHIONSEntities();
        private static bool daDuyet;
        // GET: Admin/ListArticle
        [HttpGet]
        public ActionResult ListArticle(string IsActive)
        {
            daDuyet = IsActive != null && IsActive.Equals(true);
            getListArticles();
            return View();
        }
 
        // GET: Admin/AddArticle
        public ActionResult AddArticle()
        {
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult AddArticle(ARTICLE article)
        {
            if (string.IsNullOrEmpty(article.NAME_AR))
            {
                ModelState.AddModelError("", "You need enter the post title");
                return View(article);
            }
            else {
                try
                {
                    database.ARTICLES.Add(article);
                    database.SaveChanges();
                    return RedirectToAction("ListArticle");
                }
                catch (Exception exception)
                {
                    ModelState.AddModelError("", exception.Message);
                    return View(article);
                }
            }
        }
        public ActionResult Edit(string id)
        {
            return View(database.ARTICLES.Find(id));
        }
        
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult EditArticle(ARTICLE article)
        {
            var articleInDB = database.ARTICLES.Find(article.ID_AR);
            if (string.IsNullOrEmpty(article.NAME_AR))
            {
                ModelState.AddModelError("", "You need enter the post title");
                return View(article);
            }
            else {
                try
                {
                    articleInDB.NAME_AR = article.NAME_AR;
                    articleInDB.ND = article.ND;
                    database.SaveChanges();
                    return RedirectToAction("ListArticle");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);
                    return View(article);
                }
            }
        }

        /// <summary>
        /// Dedete
        /// </summary>
        
        [HttpPost]
        public ActionResult DeleteArticle(string mabaiviet)
        {
            //---B1: dung lenh xoa bai viet dua vao ma bai viet
            ARTICLE x = database.ARTICLES.Find(mabaiviet);
            database.ARTICLES.Remove(x);
            //---B2: cap nhat database
            database.SaveChanges();
            //---B3L hien thi lai danh sach sau khi xoa
            getListArticles();
            return View("ListArticle");
        }
        /// <summary>
        /// Active
        /// </summary>
       
        [HttpPost]
        public ActionResult banArticle(string ID_AR)
        {
            //---B1: dung lenh de cam bai viet dua vao ma bai viet
            ARTICLE x = database.ARTICLES.Find(ID_AR);
            x.DADUYET = false;
            //---B2: cap nhat database
            database.SaveChanges();
            //---B3L hien thi lai danh sach sau khi xoa
            getListArticles();
            return View("ListArticle");
        }
        
        private void getListArticles()
        {
            List<ARTICLE> list1 = database.ARTICLES.Where(x => x.DADUYET == true).ToList<ARTICLE>();
            ViewData["ListArticle"] = list1;
        }

    }
}