using CoreAndFood.Models;
using CoreAndFood.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAndFood.Controllers
{
    public class AboutController : Controller
    {
        AboutRepository ar = new AboutRepository();
        AboutListRepository alr = new AboutListRepository();
        AboutUserRepository aur = new AboutUserRepository();
        AboutYorumRepository ayr = new AboutYorumRepository();
        public IActionResult Index()
        {
            var values = ar.ListT();
            return View(values);
        }

        public IActionResult DeleteAboutList(int id)
        {
            var foundId = alr.GetT(id);
            alr.DeleteT(foundId);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteAboutUser(int id)
        {
            var foundId = aur.GetT(id);
            aur.DeleteT(foundId);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteAboutYorum(int id)
        {
            var foundId = ayr.GetT(id);
            ayr.DeleteT(foundId);
            return RedirectToAction("Index");
        }

        public IActionResult AddAboutList(AboutList p)
        {
            alr.AddT(p);
            return RedirectToAction("Index");
        }

        public IActionResult AddAboutUser(AboutUser p)
        {
            aur.AddT(p);
            return RedirectToAction("Index");
        }

        public IActionResult AddAboutYorum(AboutYorum p)
        {
            ayr.AddT(p);
            return RedirectToAction("Index");
        }

        public IActionResult GetAbout(int id)
        {
            var foundId = ar.GetT(id);
            return View(foundId);
        }

        [HttpGet]
          public IActionResult UpdateAbout()
        {
            return RedirectToAction("GetAbout");
        }

        [HttpPost]
          public IActionResult UpdateAbout(About p)
        {
            ar.UpdateT(p);
            return RedirectToAction("Index");
        }


         public IActionResult GetAboutList(int id)
        {
            var foundId = alr.GetT(id);
            return View(foundId);
        }

        [HttpGet]
          public IActionResult UpdateAboutList()
        {
            return RedirectToAction("GetAboutList");
        }

        [HttpPost]
          public IActionResult UpdateAboutList(AboutList p)
        {
            alr.UpdateT(p);
            return RedirectToAction("Index");
        }


           public IActionResult GetAboutUser(int id)
        {
            var foundId = aur.GetT(id);
            return View(foundId);
        }

        [HttpGet]
          public IActionResult UpdateAboutUser()
        {
            return RedirectToAction("GetAboutUser");
        }

        [HttpPost]
          public IActionResult UpdateAboutUser(AboutUser p)
        {
            aur.UpdateT(p);
            return RedirectToAction("Index");
        }


        public IActionResult GetAboutYorum(int id)
        {
            var foundId = ayr.GetT(id);
            return View(foundId);
        }

        [HttpGet]
          public IActionResult UpdateAboutYorum()
        {
            return RedirectToAction("GetAboutYorum");
        }

        [HttpPost]
          public IActionResult UpdateAboutYorum(AboutYorum p)
        {
            ayr.UpdateT(p);
            return RedirectToAction("Index");
        }
       
       
    }
}
