using LoLHelper.Interfaces;
using LoLHelper.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
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
        public IActionResult Description(int champ)
        {
            return View(_dataprovider.GetChampAsync(champ).Result);
        }
        public IActionResult Contrpick(string champname)
        {
            var contrpick = _dataprovider.GetContrPickAsync(champname).Result;
            if(contrpick!=0)
            return RedirectToAction("Description", "Home", new { champ = contrpick });
            return RedirectToAction("ErrorWithContr", "Home");
        }
        public IActionResult DescriptionItem(int item)
        {
            return View(_dataprovider.GetItemAsync(item).Result);
        }        
        public IActionResult Items()
        {
            return View(_dataprovider.GetItems());
        }
        public IActionResult ErrorWithContr()
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