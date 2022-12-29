using DAL.Models;
using LoLHelper.Interfaces;
using LoLHelper.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace LoLHelper.Controllers
{
    public class UserBuildController:Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IDataProvider _provider;
        private readonly IPickBuilder _pickBuilder;
       public UserBuildController(UserManager<IdentityUser> userManager, IDataProvider dataProvider,IPickBuilder pickBuilder)
        {
            _userManager = userManager;
            _provider = dataProvider;
            _pickBuilder=pickBuilder;
        }
        public IActionResult UserBuild()
        {            
            return View(_provider.GetAllUserBuilds(User.FindFirstValue(ClaimTypes.NameIdentifier),"One"));
        }        
        public RedirectToRouteResult DelUserBuild(int id)
        {
            _pickBuilder.DeleteBuild(id);
            return RedirectToRoute(new { controller = "UserBuild", action = "UserBuild" });
        }
        public IActionResult AllUserBuild(SortState sortOrder = SortState.NameAsc)
        {
            var model = _provider.GetAllUserBuilds(User.FindFirstValue(ClaimTypes.NameIdentifier), "All");
            ViewData["NameSort"] = sortOrder == SortState.NameAsc ? SortState.NameDesc : SortState.NameAsc;
            ViewData["LikeSort"] = sortOrder == SortState.LikeAsc ? SortState.LikeDesc : SortState.LikeAsc;
            model = sortOrder switch
            {
                SortState.NameDesc => model.OrderByDescending(s => s.champ.Name).ToList(),
                SortState.LikeAsc => model.OrderBy(s => s.like).ToList(),
                SortState.LikeDesc => model.OrderByDescending(s => s.like).ToList(),                
                _ => model.OrderBy(s => s.champ.Name).ToList(),
            };
            return View("Userbuild",model );
        }
        public RedirectToRouteResult Like(int build)
        {
            var user = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (user == null)
            {
                return RedirectToRoute(new { controller = "Account", action = "login" });
            } 
            _provider.UpdateLike(User.FindFirstValue(ClaimTypes.NameIdentifier), build);
            return RedirectToRoute(new { controller = "UserBuild", action = "AllUserBuild" });
        }
    }
}
