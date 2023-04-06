using CoreAndFood.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreAndFood.ViewComponents
{
    public class GetAboutYorum : ViewComponent
    {
        AboutYorumRepository ayr = new AboutYorumRepository();
        public IViewComponentResult Invoke()
        {
            var values = ayr.ListT().OrderByDescending(x=>x.AboutYorumId).ToList();
            return View(values);

        }
        
    }
}