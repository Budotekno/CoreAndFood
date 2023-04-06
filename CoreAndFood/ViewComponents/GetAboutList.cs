using CoreAndFood.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Linq;


namespace CoreAndFood.ViewComponents
{
    public class GetAboutList:ViewComponent
    {
        AboutListRepository alr = new AboutListRepository();
        public IViewComponentResult Invoke()
        {
            var values = alr.ListT().OrderByDescending(x=>x.AboutListId).ToList();
            return View(values);
        }
        
    }
}