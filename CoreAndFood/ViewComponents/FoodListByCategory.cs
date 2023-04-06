using CoreAndFood.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAndFood.ViewComponents
{
    public class FoodListByCategory:ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            FoodRepository fr = new FoodRepository();
            var values = fr.List(x=>x.CategoryId==id).OrderByDescending(x=>x.FoodId).ToList();
            return View(values);
        }
    }
}
