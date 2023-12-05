using DemoCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoCode.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            if(Session["ValidateAdmin"] == null || Session["ValidateAdmin"].ToString().ToLower() != "true")
            {
                return RedirectToAction("Index", "NoAuth", new { area = "" });
            }

            Data objData = new Data();
            List<Product> obj = objData.GetProducts();
            ViewData["products"] = obj;
            return View("Index");
        }

        public ActionResult Delete(int id)
        {
            Data objData = new Data();
            objData.DeleteProduct(id);

            List<Product> obj = objData.GetProducts();
            ViewData["products"] = obj;
            return View("Index");
        }
    }
}