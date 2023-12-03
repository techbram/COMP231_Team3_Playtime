using DemoCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoCode.Controllers
{
    public class AddCategoryController : Controller
    {
        // GET: AddCategory
        public ActionResult Index()
        {
            //Category obj = new Category();
            ViewData["Category"] = null;
            return View();
        }


        public ActionResult Edit(int id)
        {
            Data objData = new Data();
            Category obj = objData.GetCategoryById(id);
            ViewData["Category"] = obj;
            return View("Index");
        }


        [HttpPost]
        public ActionResult Add(Category obj)
        {

            Data objData = new Data();

            objData.AddCategory(obj);
            return RedirectToAction("Index", "Category", new { area = "" });
        }

        [HttpPost]
        public ActionResult EditCategory(Category obj)
        {
            Data objData = new Data();

            objData.EditCategory(obj.Id, obj.Name,Convert.ToInt32(obj.IsActive));
            return RedirectToAction("Index", "Category", new { area = "" });
        }

    }
}