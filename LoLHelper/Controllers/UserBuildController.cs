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
       public UserBuildController(UserManager<IdentityUser> userManager, IDataProvider dataProvider)
        {
            _userManager = userManager;
            _provider = dataProvider;
        }
        public IActionResult UserBuild()
        {            
            return View(_provider.GetAllUserBuilds(User.FindFirstValue(ClaimTypes.NameIdentifier)));
        }
    }
}
