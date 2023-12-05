using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoCode.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {

            Session["ValidateAdmin"] = null;
            Session.Abandon();
            return RedirectToAction("Index", "Home", new { area = "" });
        }
    }
}