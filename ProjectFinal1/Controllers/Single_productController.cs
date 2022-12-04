using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectFinal1.Models;
namespace ProjectFinal1.Controllers
{
    public class Single_productController : Controller
    {
        // GET: Single_product
        public ActionResult Index(string masp)
        {
            // get product
            MEN_FASHIONSEntities db = new MEN_FASHIONSEntities();
            PRODUCT x = db.PRODUCTS.Where(y => y.ID_PR.Equals(masp)).First();
            //
            ViewData["PRODUCT"] = x;
            return View();
        }
    }
}