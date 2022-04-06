﻿using Client.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Client.Controllers
{
    public class LatihanController : Controller
    {
        private readonly ILogger<LatihanController> _logger;

        public LatihanController(ILogger<LatihanController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Starwars()
        {
            return View();
        }

        public IActionResult Pokemon()
        {
            return View();
        }

        public IActionResult MasterData()
        {
            return View();
        }
    }
}
