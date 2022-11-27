using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectFinal1.Controllers;
using ProjectFinal1.Models;

namespace ProjectFinal1.Controllers
{
    public class Single_productController : Controller
    {
        // GET: Single_product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Index(string ID_PR)
        { 
            
            MEN_FASHIONSEntities db = new MEN_FASHIONSEntities();

            PRODUCT pr = db.PRODUCTS.Where(x => x.ID_PR == ID_PR).First<PRODUCT>();
                ViewData["Single_Product"] = pr;
;            return View();
        }
    }
}