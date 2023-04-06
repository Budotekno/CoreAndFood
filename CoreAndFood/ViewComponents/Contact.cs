using CoreAndFood.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAndFood.ViewComponents
{
    public class Contact:ViewComponent
    {
       public IViewComponentResult Invoke()
        {
            ContactRepository cr = new ContactRepository();
            var values = cr.ListT();
            return View(values);
        }
    }
}
