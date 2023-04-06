using CoreAndFood.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Linq;


namespace CoreAndFood.ViewComponents
{
    public class GetServiceList:ViewComponent
    {
        ServiceListRepository slr = new ServiceListRepository();
        public IViewComponentResult Invoke()
        {
            var values = slr.ListT().OrderByDescending(x=>x.ServiceListId).ToList();
            return View(values);
        }
        
    }
}