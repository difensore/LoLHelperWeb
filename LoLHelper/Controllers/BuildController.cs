using DAL.ViewModels;
using LoLHelper.Interfaces;
using LoLHelper.Models;
using LoLHelper.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Data;
using System.Diagnostics;
using System.Security.Claims;
using Controller = Microsoft.AspNetCore.Mvc.Controller;
using SelectListItem = Microsoft.AspNetCore.Mvc.Rendering.SelectListItem;

namespace LoLHelper.Controllers
{
    public class BuildController : Controller
    {
        private readonly IDataProvider _dataprovider;        
        private readonly IPickBuilder _pb;

        public BuildController(IDataProvider datapovider,IPickBuilder pb)
        {
            _dataprovider = datapovider;            
            _pb=pb;
        }
        [HttpGet]
        public IActionResult Build()
        {
            var user = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (user == null)
            {
                return RedirectToRoute(new { controller = "Account", action = "login" });
            }
            PickViewModel _pickViewModel = new PickViewModel();
            var champs = _dataprovider.GetChamps();
            var items = _dataprovider.GetItems();
            var spells = _dataprovider.GetSpells();
            var runes = _dataprovider.GetAllRunes();
            var mainrunes = _dataprovider.GetAllMainRunes();
            var extrarunes = _dataprovider.GetAlExtraRunes();
            foreach (var c in champs)
            {
                _pickViewModel.champs.Add(new SelectListItem { Text = c.Name, Value = c.Id.ToString() });
            }
            foreach (var i in items)
            {
                _pickViewModel.items.Add(new SelectListItem { Text = i.Name, Value = i.Id.ToString() });
            }
            foreach (var s in spells)
            {
                _pickViewModel.spells.Add(new SelectListItem { Text = s.Name, Value = s.Id.ToString() });
            }
            foreach (var r in runes)
            {
                _pickViewModel.runes.Add(new SelectListItem { Text = r.Name, Value = r.Id.ToString() });
            }
            foreach (var mr in mainrunes)
            {
                _pickViewModel.mainRunes.Add(new SelectListItem { Text = mr.Name, Value = mr.Id.ToString() });
            }
            foreach (var er in extrarunes)
            {
                _pickViewModel.extraRunes.Add(new SelectListItem { Text = er.Name, Value = er.Id.ToString() });
            }
            return View(_pickViewModel);
        }
        [HttpPost]
        public RedirectToRouteResult Build(PickViewModel pickViewModel)
        {
            pickViewModel.currentUser = User.FindFirstValue(ClaimTypes.NameIdentifier);
            _pb.CreateBuild(pickViewModel);
            return RedirectToRoute(new { controller = "UserBuild", action = "UserBuild" });
        }
    }
}
