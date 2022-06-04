using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationTest.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello
        public ActionResult Index()
        {
            ViewBag.Cities = new List<string>(){ "KTM", "Birgung", "Biratnargar", "Pokhara" };

            ViewData["Cities"] = new List<string>() { "KTM", "Birgung", "Biratnargar", "Pokhara" };

            TempData["name"] = "Shyam";
            return View("Index1");
        }
    }
}