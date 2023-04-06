using CoreAndFood.Models;
using CoreAndFood.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAndFood.Controllers
{
    public class UserController : Controller
    {
        AdminRepository ar = new AdminRepository();
        public IActionResult Index()
        {
            var values = ar.ListT().OrderByDescending(x=>x.AdminId).ToList();
            return View(values);
        }

        public IActionResult AddUser(Admin p)
        {
            ar.AddT(p);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteUser(int id)
        {
            var foundId = ar.GetT(id);
            ar.DeleteT(foundId);
            return RedirectToAction("Index");
        }

        public IActionResult GetUser(int id)
        {
            var foundId = ar.GetT(id);
            return View(foundId);
        }

        [HttpGet]
        public IActionResult UpdateUser()
        {
            return RedirectToAction("GetUser");
        }

        [HttpPost]
        public IActionResult UpdateUser(Admin p)
        {
            ar.UpdateT(p);
            return RedirectToAction("Index");
        }

        
    }
}
