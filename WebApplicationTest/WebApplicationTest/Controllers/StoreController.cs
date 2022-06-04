using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationTest.Controllers
{
    public class StoreController : Controller
    {
        // GET: /Store
        public string Index()
        {
            return "Hello from Store.Index";
        }
        //GET : /Store/Browse
        public string Browse()
        {
            return "Hello from Store.Browse";
        }
        //GET : /Store/Detail
        public string Detail()
        {
            return "Hello from Store.Detail";
        }
    }
}