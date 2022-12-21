using Microsoft.AspNetCore.Mvc;

namespace LoLHelper.Controllers
{
    public class UserBuildController:Controller
    {
        public UserBuildController()
        {

        }
        public IActionResult UserBuild()
        {

            return View();
        }
    }
}
