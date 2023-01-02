using DAL.Models;
using LoLHelper.Interfaces;
using LoLHelper.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Diagnostics;

namespace LoLHelper.Controllers
{
    public class HomeController : Controller
    {        
        private readonly IDataProvider _dataprovider;
        private readonly ISortedPaginationBuilder _paginationBuilder;
        public HomeController( IDataProvider datapovider,ISortedPaginationBuilder paginationBuilder)
        {            
            _dataprovider = datapovider;   
            _paginationBuilder = paginationBuilder;
        }
        public IActionResult Index(SortState sortOrder = SortState.NameAsc, int page = 1)
        {
            var model = _dataprovider.GetChamps();
            return View(_paginationBuilder.CreatebyChamps(sortOrder, page, model)  );
        }
        public IActionResult Description(int champ, int entity)
        {
            try
            {
                return View(_dataprovider.GetChampAsync(champ, entity).Result);
            }
            catch
            {
                return View("ErrorWithContr");
            }
        }
        public IActionResult Contrpick(string champname)
        {
            var contrpick = _dataprovider.GetContrPickAsync(champname).Result;
            if(contrpick!=0)
            return RedirectToAction("Description", "Home", new { champ = contrpick, entity=1 });
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