using CoreAndFood.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAndFood.ViewComponents
{
    public class CategoryGetList:ViewComponent
    {
         public IViewComponentResult Invoke()
        {
            CategoryRepository cr = new CategoryRepository();
            var values = cr.ListT().Where(x=>x.Status==true).OrderBy(x=>x.CategoryName).ToList();
            return View(values);
        }
    }
}
