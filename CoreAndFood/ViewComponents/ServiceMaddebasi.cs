using System.Linq;
using CoreAndFood.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CoreAndFood.ViewComponents
{
    public class ServiceMaddebasi:ViewComponent
    {
        ServiceListRepository slr = new ServiceListRepository();

        public IViewComponentResult Invoke()
        {
             var values = slr.ListT().OrderByDescending(x=>x.ServiceListId).ToList();
            return View(values);
        }
        
    }
}