using ITNext___Online_PC_Market.Models;
using ITNext___Online_PC_Market.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.SessionState;

namespace ITNext___Online_PC_Market.Controllers
{
    [SessionState(SessionStateBehavior.Required)]
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
            if (User.IsInRole("Administrator"))
            {
                return View("AdminIndex",items);
            }
            return View("Index", items);
            
        }
        public ActionResult Details(int? id)
        {
            var product = _context.items.SingleOrDefault(m => m.Id == id);
            if (User.IsInRole("Administrator"))
            {
                return View("AdminDetails",product);
            }
            return View(product);
        }
        [Authorize(Roles = "Administrator")]
        public ActionResult Create()
        {
            ItemsTipViewModel model = new ItemsTipViewModel();
            model.categories = _context.categories.ToList();
            return View(model);
        }
        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public ActionResult Create(ItemsTipViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                viewModel.categories = _context.categories.ToList();
                return View("Create",viewModel);
            }
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
            return RedirectToAction("Index");
        }
        [Authorize(Roles = "Administrator")]
        public ActionResult Edit(int id)
        {
            ItemsTipViewModel model = new ItemsTipViewModel();
            model.categories = _context.categories.ToList();
            var item = _context.items.SingleOrDefault(m => m.Id == id);
            model.item = item;
            return View(model);
        }
        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public ActionResult Edit(ItemsTipViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.categories = _context.categories.ToList();
                return View("Edit",model);
            }
            int id = model.item.Id;
            var item = _context.items.SingleOrDefault(m => m.Id == id);
            Tip tipNaProdukt = _context.categories.SingleOrDefault(m => m.Id == model.item.TipId);
            item.Name = model.item.Name;
            item.Price = model.item.Price;
            item.Desc = model.item.Desc;
            item.ImgURL = model.item.ImgURL;
            item.Stock = model.item.Stock;
            item.TipId = model.item.TipId;
            item.Tip = tipNaProdukt;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize(Roles ="Administrator")]
        public ActionResult Delete(int id)
        {
            var model = _context.items.SingleOrDefault(m => m.Id == id);
            _context.items.Remove(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}