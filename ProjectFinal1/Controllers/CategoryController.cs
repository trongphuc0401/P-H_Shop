using ProjectFinal1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectFinal1.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        
        public ActionResult Index(int ID_L)
        {
           
            return View();
        }
    

    }
}