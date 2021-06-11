using BusinnesLayer.Concrete;
using BusinnesLayer.ValidationRules;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concerete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FluentValidation.Results;

namespace MVCProjeKampı.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category

        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        public ActionResult Index()
        {

            return View();


        }
        public ActionResult GetCategoryList()
        {

            var categoryValues = cm.GetList();
            return View(categoryValues);

        }
        [HttpGet]
        public ActionResult AddCategory()
        {

            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(Category category)
        {

            //cm.CategoryAddBL(category);

            CategoryValidator categoryValidator = new CategoryValidator();
            ValidationResult result = categoryValidator.Validate(category);

            if (result.IsValid)
            {
                cm.CategoryAddBL(category);
                return RedirectToAction("GetCategoryList");
            
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                    
             
                }

                return View();
            }
         


        }



    }
}