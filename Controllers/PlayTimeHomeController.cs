using DemoCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoCode.Controllers
{
    public class PlayTimeHomeController : Controller
    {
        // GET: PlayTimeHome
        public ActionResult Index()
        {
            Data objData = new Data();
            List<Product> cat1products = objData.GetProductsByCategory(3004);
            List<Product> cat2products = objData.GetProductsByCategory(3005);
            List<Product> cat3products = objData.GetProductsByCategory(3006);

            ViewData["cat1products"] = cat1products;
            ViewData["cat2products"] = cat2products;
            ViewData["cat3products"] = cat3products;

            return View("Index");
        }
    }
}