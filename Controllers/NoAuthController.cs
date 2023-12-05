using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoCode.Controllers
{
    public class NoAuthController : Controller
    {
        // GET: NoAuth
        public ActionResult Index()
        {
            return View();
        }
    }
}