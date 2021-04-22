using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CosmosWholesaleProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using CosmosWholesaleProject.Helpers;

namespace CosmosWholesaleProject.Controllers
{
    public class CartController : Controller
    {
        private readonly ProductContext db;
        public CartController(ProductContext db)
        {
            this.db = db;
        }
        //public string strCart = "Cart";
        public ActionResult Index()
        {
            var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            ViewBag.cart = cart;
            ViewBag.total = cart.Sum(cart => cart.Product.Price * cart.Quantity);
            return View();
        }
        public ActionResult OrderNow(int? id)
        {
            if (SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart") == null)
            {
                List<Cart> cart = new List<Cart>();
                new Cart (db.Products.Find(id),1 );
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            else
            {
                List<Cart> cart = SessionHelper.GetObjectFromJson<List<Cart>>(HttpContext.Session, "cart");
                int index = IsExist(id);
                if (index != -1)
                {
                    cart[index].Quantity++;
                }
                else
                {
                    new Cart (db.Products.Find(id),1);
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            return RedirectToAction("Food");
        }
        private int IsExist(int? id)
        {
            List<Cart> cart = SessionHelper.GetObjectFromJson<List<Cart>>(HttpContext.Session, "cart");
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].Product.ProductID.Equals(id))
                {
                    return i;
                }
            }
            return -1;
        }
    }
        
}