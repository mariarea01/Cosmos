using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using CosmosWholesaleProject.Models;

namespace CosmosWholesaleProject.Controllers
{

    public class ProductController : Controller
    {
        private readonly ProductContext db;
        public ProductController(ProductContext db)
        {
            this.db = db;
        } 
 
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult ProductListPartial(/*int? page*/)
        {
            //var pageNumber = page ?? 1;
            //var pageSize = 10;
            var productList = db.Products.OrderByDescending(x => x.ProductID);
            return PartialView(productList);
        }

    }
}