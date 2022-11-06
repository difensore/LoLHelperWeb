﻿using LoLHelper.Interfaces;
using LoLHelper.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LoLHelper.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IDataProvider _dataprovider;
        public HomeController(ILogger<HomeController> logger, IDataProvider datapovider)
        {
            _logger = logger;
            _dataprovider = datapovider;    
        }

        public IActionResult Index()
        {           
            return View(_dataprovider.GetChamps());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}