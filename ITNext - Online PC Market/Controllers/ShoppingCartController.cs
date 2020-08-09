using ITNext___Online_PC_Market.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITNext___Online_PC_Market.Controllers
{
    public class ShoppingCartController : Controller
    {
        public ApplicationDbContext _context;
        public ShoppingCartController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: ShoppingCart
        public ActionResult Index()
        {
            return View((List<CartItem>)Session["cart"]);
        }
        [HttpPost]
        public ActionResult AddToCart(int id,int quantity)
        {
            if (Session["cart"] == null)
            {
                List<CartItem> list = new List<CartItem>();
                var product = (Item)_context.items.Find(id);
                CartItem item = new CartItem { Product = product, Quantity = quantity };
                list.Add(item);
                Session["cart"] = list;

            }
            else
            {
                List<CartItem> list = (List<CartItem>)Session["cart"];
                var product = (Item)_context.items.Find(id);
                CartItem item = new CartItem { Product = product, Quantity = quantity };
                list.Add(item);
            }
            return RedirectToAction("Index", "Products");
        }
        [HttpPost]
        public ActionResult DeleteCartItem(int id)
        {
            List<CartItem> list = (List<CartItem>)Session["cart"];
            foreach(CartItem item in list)
            {
                if (item.Product.Id.Equals(id))
                {
                    list.Remove(item);
                    break;
                }
            }
            Session["cart"] = list;
            return RedirectToAction("Index", "ShoppingCart");
        }
    }
}