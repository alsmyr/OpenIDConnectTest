using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OpenIDConnectTest.Controllers
{
    public class HomeController : Controller
    {
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Protected()
        {
            ViewBag.Message = "This is a Protected Page!";

            return View();
        }

        
    }
}