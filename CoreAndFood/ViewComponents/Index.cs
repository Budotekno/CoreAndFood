﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAndFood.ViewComponents
{
    public class Index:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
