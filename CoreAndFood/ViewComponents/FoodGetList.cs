using CoreAndFood.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAndFood.ViewComponents
{
    public class FoodGetList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            FoodRepository fr = new FoodRepository();
            var values = fr.ListT().OrderByDescending(x=>x.FoodId).ToList();
            return View(values);
        }
    }
}
