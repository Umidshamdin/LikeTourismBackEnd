﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    public class FamousCityController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
