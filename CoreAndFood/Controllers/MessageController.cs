using CoreAndFood.Models;
using CoreAndFood.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAndFood.Controllers
{
    public class MessageController : Controller
    {
        MessageRepository mr = new MessageRepository();

        public IActionResult Index()
        {
            var values = mr.ListT().OrderByDescending(x => x.MessageId).ToList();
            return View(values);
        }
        

        public IActionResult DeleteMessage(int id)
        {
            var foundId = mr.GetT(id);
            mr.DeleteT(foundId);
            return RedirectToAction("Index");
        }
    }
}
