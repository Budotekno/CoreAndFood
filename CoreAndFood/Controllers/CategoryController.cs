using CoreAndFood.Models;
using CoreAndFood.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAndFood.Controllers
{
   // [AllowAnonymous]
    public class CategoryController : Controller
    {
        CategoryRepository cr = new CategoryRepository();

      
        public IActionResult Index()
        {
            var values = cr.ListT().OrderByDescending(x => x.CategoryId).OrderBy(x=>x.CategoryName).OrderByDescending(x=>x.Status==true).ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCategory(Category p)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }
            p.Status = true;
            cr.AddT(p);
            return RedirectToAction("Index");
        }

        public IActionResult GetCategory(int id)
        {
            var value = cr.GetT(id);
            return View(value);
        }

        [HttpGet]
        public IActionResult EditCategory()
        {
            return RedirectToAction("GetCategory");
        }

        [HttpPost]
        public IActionResult EditCategory(Category p)
        {
           
            cr.UpdateT(p);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteCategory(int id)
        {
            var valueId = cr.GetT(id);
            if (valueId.Status == true)
            {
                valueId.Status = false;
            }
            else
            {
                valueId.Status = true;
            }
            cr.UpdateT(valueId);
            return RedirectToAction("Index");
        }
    }
}
