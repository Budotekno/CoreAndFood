using CoreAndFood.Models;
using CoreAndFood.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAndFood.Controllers
{
    public class Contact1 : Controller
    {
        ContactRepository cr = new ContactRepository();

        public IActionResult Index()
        {
            var values = cr.ListT();
            return View(values);
        }

        public IActionResult GetContact(int id)
        {
            var foundId = cr.GetT(id);
            return View(foundId);
        }

        [HttpGet]
        public IActionResult UpdateContact()
        {
            return RedirectToAction("GetContact");
        }

        [HttpPost]
        public IActionResult UpdateContact(Contact p)
        {
            cr.UpdateT(p);
            return RedirectToAction("Index");
        }
    }
}
