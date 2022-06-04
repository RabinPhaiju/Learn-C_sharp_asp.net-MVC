using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string name)
        {
        // https://localhost:44337/Home/Index?name=rabsaa
            // prevent sql injection
            string message = HttpUtility.HtmlEncode("Your application description page. " + name);
            ViewBag.Message = message;
            return View();
            return View("~/Views/Home/Index.cshtml");
            return View("~/Views/Example/Index.cshtml");
        }
        public string parameterpass(string id, string name)
        {
        // https://localhost:44337/home/parameterpass/10?name=rabin
        // prevent sql injection
        string message = HttpUtility.HtmlEncode("The value of id = " + id + " and name = " + name);
            return message;
        }
        public string parameterid(string id)
        {
            return "The value of id = "+id + " and name = "+Request.QueryString["name"];
        }

        public ActionResult About(string name)
        {
            // https://localhost:44337/home/about?name=rabin
            // prevent sql injection
            string message = HttpUtility.HtmlEncode("Your application description page. "+name);
            ViewBag.Message = message;
            if (TempData.ContainsKey("name"))
            {
                ViewBag.Name = TempData["name"].ToString();
            }
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult TestView()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}