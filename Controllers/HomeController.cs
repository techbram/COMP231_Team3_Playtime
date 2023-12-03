using DemoCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoCode.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ValidateAdmin(Admin obj)
        {
            Data objData = new Data();
            bool result = false;
            result = objData.ValidateAdmin(obj.Username, obj.Password);
            if(result)
            {
                Session["ValidateAdmin"] = true;
            }

            return RedirectToAction("Index", "Product", new { area = "" });
        }

    }
}