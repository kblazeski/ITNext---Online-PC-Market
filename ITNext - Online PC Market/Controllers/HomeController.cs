using ITNext___Online_PC_Market.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITNext___Online_PC_Market.Controllers
{
    public class HomeController : Controller
    {
        public ApplicationDbContext _context;
        public HomeController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
            base.Dispose(disposing);
        }
        public ActionResult Index()
        {
            Random rnd = new Random();
            List<Item> items = _context.items.ToList();
            items = items.OrderBy(x => rnd.Next()).Take(8).ToList();
            return View(items);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}