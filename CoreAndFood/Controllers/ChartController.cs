using CoreAndFood.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAndFood.Controllers
{
    public class ChartController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult VisualizeProductResult()
        {
            return Json(ProList());
        }

        public List<Class1> ProList()
        {
            List<Class1> cs = new List<Class1>();
            cs.Add(new Class1()
            {
                proname = "Ürün1",
                stock = 100
            });

            cs.Add(new Class1()
            {
                proname = "Ürün2",
                stock = 230
            });

            cs.Add(new Class1()
            {
                proname = "Ürün3",
                stock = 422
            });

            return cs;
        }

        public IActionResult Statistic()
        {
            var d1 = c.Foods.Count();
            ViewBag.d1 = d1;

            var d2 = c.Categories.Count();
            ViewBag.d2 = d2;

            var meyveId = c.Categories.Where(x => x.CategoryName == "Meyve").Select(y => y.CategoryId).FirstOrDefault();
            var d3 = c.Foods.Where(x=>x.CategoryId==meyveId).Count();
            ViewBag.d3 = d3;

            var icecekd = c.Categories.Where(x => x.CategoryName == "İçecek").Select(y => y.CategoryId).FirstOrDefault();
            var d4 = c.Foods.Where(x=>x.CategoryId==icecekd).Count();
            ViewBag.d4 = d4;

            var d5 = c.Foods.Sum(x=>x.Stock);
            ViewBag.d5 = d5;


            var sebzeId = c.Categories.Where(x => x.CategoryName == "Sebze").Select(y => y.CategoryId).FirstOrDefault();
            var d6 = c.Foods.Where(x => x.CategoryId == sebzeId).Count();
            ViewBag.d6 = d6;

            var d7 = c.Foods.OrderByDescending(x=>x.Stock).Select(y=>y.Name).FirstOrDefault();
            ViewBag.d7 = d7;

            var d8 = c.Foods.OrderBy(x => x.Stock).Select(y => y.Name).FirstOrDefault();
            ViewBag.d8 = d8;

            var d9 = c.Foods.Average(x => x.Price).ToString("0.00");
            ViewBag.d9 = d9;


            var dIcecek = c.Categories.Where(x => x.CategoryName == "İçecek").Select(y => y.CategoryId).FirstOrDefault();
            var d10 = c.Foods.Where(y => y.CategoryId == dIcecek).Sum(x => x.Stock);
            ViewBag.d10 = d10;

            var dMeyve = c.Categories.Where(x => x.CategoryName == "Meyve").Select(y => y.CategoryId).FirstOrDefault();
            var d11 = c.Foods.Where(y => y.CategoryId == dMeyve).Sum(x => x.Stock);
            ViewBag.d11 = d11;

            var d12 = c.Foods.OrderByDescending(x => x.Price).Select(y => y.Name).FirstOrDefault();
            ViewBag.d12 = d12;






            return View();
        }
    }
}
