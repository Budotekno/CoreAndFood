using CoreAndFood.Models;
using CoreAndFood.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAndFood.Controllers
{
    public class ServicesController : Controller
    {
        ServiceRepository sr = new ServiceRepository();
        ServiceListRepository slr = new ServiceListRepository();
        public IActionResult Index()
        {
            var values = sr.ListT();
            return View(values);
        }

        public IActionResult GetServices(int id)
        {
            var foundId = sr.GetT(id);
            return View(foundId);
        }

        [HttpGet]
        public IActionResult UpdateService()
        {
            return RedirectToAction("GetServices");
        }

        [HttpPost]
        public IActionResult UpdateService(Service p)
        {
           sr.UpdateT(p);
            return RedirectToAction("Index");
        }


        public IActionResult AddServiceList(ServiceList p)
        {
            slr.AddT(p);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteServiceList(int id)
        {
            var foundId= slr.GetT(id);
            slr.DeleteT(foundId);
            return RedirectToAction("Index");

        }

        public IActionResult GetServiceList(int id)
        {
             var foundId= slr.GetT(id);
            return View(foundId);

        }

         [HttpGet]
        public IActionResult UpdateServiceList()
        {
            return RedirectToAction("GetServicesList");
        }

        [HttpPost]
        public IActionResult UpdateServiceList(ServiceList p)
        {
           slr.UpdateT(p);
            return RedirectToAction("Index");
        }
    }
}
