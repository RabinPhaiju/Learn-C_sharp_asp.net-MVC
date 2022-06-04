using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationTest.Models;

namespace WebApplicationTest.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            // Product product = new Product()
            TestProduct[] products =
            {
                new TestProduct
                {
                    Id = 1,
                    Name = "car",
                    Price = 23.444f
                },
        new TestProduct{
            Id = 2,
            Name = "test",
            Price = 30.344f
            }
            };
            return View(products);
        }
    }
}