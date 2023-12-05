using DemoCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoCode.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {

            if (Session["ValidateAdmin"] == null || Session["ValidateAdmin"].ToString().ToLower() != "true")
            {
                return RedirectToAction("Index", "NoAuth", new { area = "" });
            }

            Data objData = new Data();
            List<Category> obj = objData.GetCategories();
            ViewData["Categories"] = obj;
            return View("Index");
        }

        public ActionResult Delete(int id)
        {
            Data objData = new Data();
            objData.DeleteCategory(id);

            List<Category> obj = objData.GetCategories();
            ViewData["Categories"] = obj;
            return View("Index");
        }        
    }
}