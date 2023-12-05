using DemoCode.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoCode.Controllers
{
    public class AddProductController : Controller
    {
        Product objEditProduct = null;


        // GET: AddProduct
        public ActionResult Index()
        {
            if (Session["ValidateAdmin"] == null || Session["ValidateAdmin"].ToString().ToLower() != "true")
            {
                return RedirectToAction("Index", "NoAuth", new { area = "" });
            }

            Data objData = new Data();
            List<Category> categories = objData.GetCategories();
            ViewData["product"] = objEditProduct;
            ViewData["categories"] = categories;
            return View();
        }


        public ActionResult Edit(int id)
        {
            Data objData = new Data();
            objEditProduct = objData.GetProductsById(id);
            List<Category> categories = objData.GetCategories();
            ViewData["product"] = objEditProduct;
            ViewData["categories"] = categories;
            return View("Index");
        }


        [HttpPost]
        public ActionResult Add(Product obj)
        {

            Data objData = new Data();

            objData.AddProduct(obj.Name, obj.CategoryId, obj.Desc, obj.Price, obj.Imagelg, obj.ImageSm, obj.AgeGroup, Convert.ToInt32(obj.IsActive));
            return RedirectToAction("Index", "Product", new { area = "" });
        }

        [HttpPost]
        public ActionResult EditProduct(Product obj)
        {
            Data objData = new Data();

            objData.EditProduct(obj.Id, obj.Name, obj.CategoryId, obj.Desc, obj.Price, obj.Imagelg, obj.ImageSm, obj.AgeGroup, Convert.ToInt32(obj.IsActive));
            return RedirectToAction("Index", "Product", new { area = "" });
        }

        [HttpPost]
        public ActionResult UploadFile(HttpPostedFileBase file, Product obj)
        {
            Data objData = new Data();
            try
            {
                if (file.ContentLength > 0)
                {
                    string _FileName = Path.GetFileName(file.FileName);
                    string _path = Path.Combine(Server.MapPath("~/Content/Images"), _FileName);
                    file.SaveAs(_path);

                    objEditProduct = objData.EditProductImage(obj.Id, _FileName);
                    List<Category> categories = objData.GetCategories();
                    ViewData["product"] = objEditProduct;
                    ViewData["categories"] = categories;
                }
                ViewBag.Message = "File Uploaded Successfully!!";
                return View("Index");
            }
            catch
            {
                ViewBag.Message = "File upload failed!!";
                return View("Index");
            }
        }

    }
}