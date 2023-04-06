using CoreAndFood.Models;
using CoreAndFood.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace CoreAndFood.Controllers
{
    public class FoodController : Controller
    {
        FoodRepository fr = new FoodRepository();
        Context c = new Context();

        public IActionResult Index(int page = 1)
        {
            var values = fr.ListT("Category").OrderByDescending(x => x.FoodId).ToList().ToPagedList(page,10);
            return View(values);
        }

        [HttpGet]
        public IActionResult AddFood()
        {
            List<SelectListItem> CategoryList = (from x in c.Categories.Where(x=>x.Status==true).OrderBy(x=>x.CategoryName).ToList()
                                                     select new SelectListItem
                                                     {
                                                         Text = x.CategoryName,
                                                         Value = x.CategoryId.ToString()
                                                     }
                                                 ).ToList();

            ViewBag.CategoryList = CategoryList;
            return View();
        }

        [HttpPost]
        public IActionResult AddFood(Food p)
        {
            fr.AddT(p);
            return RedirectToAction("Index");
        }

        
        public IActionResult DeleteFood(int id)
        {
            fr.DeleteT(new Food { FoodId = id });
            return RedirectToAction("Index");
        }

        public IActionResult GetFood(int id)
        {
            var value = fr.GetT(id);
            List<SelectListItem> CategoryList = (from x in c.Categories.Where(x => x.Status == true).OrderBy(x => x.CategoryName).ToList()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.CategoryName,
                                                     Value = x.CategoryId.ToString()
                                                 }
                                                ).ToList();

            ViewBag.CategoryList = CategoryList;
            return View(value);
        }

        [HttpGet]
        public IActionResult EditFood()
        {
            return RedirectToAction("GetFood");
        }

        [HttpPost]
        public IActionResult EditFood(Food p)
        {
            fr.UpdateT(p);
            return RedirectToAction("Index");
        }
    }
}
