using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationTest.Models
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            LoginModel model = new LoginModel()
            { Password = "xyz", RememberMe =true, Name = "rbnph"};
            ViewBag.ReturnUrl = "http://www.google.com";
            return View(model);
            return View();
        }
        public ActionResult ExternalLoginsList(string ReturnUrl)
        {
            return Redirect(ReturnUrl);
        }
    }
}