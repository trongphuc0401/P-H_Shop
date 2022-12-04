using ProjectFinal1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectFinal1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Index
        [HttpGet]
        public ActionResult Index()
        {
            MEN_FASHIONSEntities DB= new MEN_FASHIONSEntities();
           
            return View();
        }
        public ActionResult addToCart(string ID_PR)
        {
            Cart cart= Session["CartShop"] as Cart;
            cart.addItem(ID_PR);
            Session["Cartshop"]=cart;
            return View("Index");
        }
    }
}