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
    [AllowAnonymous]
    public class VitrinController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CategoryDetails(int id)
        {
            ViewBag.id = id;
            CategoryRepository cr = new CategoryRepository();
            ViewBag.categoryName = cr.List(x => x.CategoryId == id).Select(y => y.CategoryName).FirstOrDefault();
            return View();
        }

        public IActionResult About()
        {
            AboutRepository ar = new AboutRepository();
            var values = ar.ListT();
            return View(values);
        }

        public IActionResult Services()
        {
            ServiceRepository sr = new ServiceRepository();
            var values = sr.ListT();
            return View(values);
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddMessage()
        {
            return RedirectToAction("Contact");

        }

        [HttpPost]
        public IActionResult AddMessage(Message p)
        {
            MessageRepository mr = new MessageRepository();
            mr.AddT(p);
            return RedirectToAction("Contact");

        }

    
        

    }
}
