using CoreAndFood.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace CoreAndFood.Controllers
{
    public class LoginController : Controller
    {
        Context c = new Context();
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost] 
        public async  Task<IActionResult> Index(Admin p)
        {
            var value = c.Admins.FirstOrDefault(x => x.UserName == p.UserName && x.UserPassword == p.UserPassword);
            if (value!=null)
            {
                var calims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,p.UserName)
                };
                var userIdentity = new ClaimsIdentity(calims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);
                return Redirect("/Category/Index/");

            }
            return View();

        }

        [HttpGet]
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Login");
        }
    }
}
