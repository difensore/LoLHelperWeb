using LoLHelper.Interfaces;
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
            return View(_provider.GetAllUserBuilds(User.FindFirstValue(ClaimTypes.NameIdentifier)));
        }        
        public RedirectToRouteResult DelUserBuild(int id)
        {
            _pickBuilder.DeleteBuild(id);
            return RedirectToRoute(new { controller = "UserBuild", action = "UserBuild" });
        }
    }
}
