<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YeniEmlak.Models;

namespace YeniEmlak.Controllers
{
    public class HomeController : Controller
    {
        public readonly YeniEmlakDbContext _yeniEmlakDbContext;
        public HomeController(YeniEmlakDbContext dbContext)
        {
            _yeniEmlakDbContext = dbContext;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YeniEmlak.Models;

namespace YeniEmlak.Controllers
{
    public class HomeController : Controller
    {
        public readonly YeniEmlakDbContext _yeniEmlakDbContext;
        public HomeController(YeniEmlakDbContext dbContext)
        {
            _yeniEmlakDbContext = dbContext;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
>>>>>>> a6338ffe060c15c90e0a149ba25fa79f0ffbe7b8
}