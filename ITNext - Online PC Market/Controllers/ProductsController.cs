using ITNext___Online_PC_Market.Models;
using ITNext___Online_PC_Market.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITNext___Online_PC_Market.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ApplicationDbContext _context;
        public ProductsController()
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
            IEnumerable<Item> items = _context.items.ToList();
            return View(items);
        }
        public ActionResult Create()
        {
            ItemsTipViewModel model = new ItemsTipViewModel();
            model.categories = _context.categories.ToList();
            return View(model);
        }
        [HttpPost]
        public ActionResult Create(ItemsTipViewModel viewModel)
        {
            Tip tipNaProdukt = _context.categories.SingleOrDefault(m => m.Id == viewModel.item.TipId);
            Item item = new Item();
            item.Name = viewModel.item.Name;
            item.Price = viewModel.item.Price;
            item.Stock = viewModel.item.Stock;
            item.Desc = viewModel.item.Desc;
            item.Tip = tipNaProdukt;
            item.TipId = viewModel.item.TipId;
            item.ImgURL = viewModel.item.ImgURL;
            _context.items.Add(item);
            _context.SaveChanges();
            return RedirectToAction("AllProducts");
        }
    }
}