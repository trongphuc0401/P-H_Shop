using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectFinal1.Models;
namespace ProjectFinal1.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        [HttpGet]
        public ActionResult Index()
        {
            Cart cart = Session["CartShop"] as Cart;

            ViewData["Cart"] = cart;
            return View();
        }
    }
}