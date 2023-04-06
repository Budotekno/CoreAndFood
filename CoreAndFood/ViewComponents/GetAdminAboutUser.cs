using CoreAndFood.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreAndFood.ViewComponents
{
    public class GetAdminAboutUser:ViewComponent
    {
        AboutUserRepository aur = new AboutUserRepository();
        public IViewComponentResult Invoke()
        {
            var values = aur.ListT().OrderByDescending(x=>x.AboutUserId).ToList();
            return View(values);
        }
        
    }
}