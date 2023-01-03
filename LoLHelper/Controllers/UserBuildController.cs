using DAL.Models;
using LoLHelper.Interfaces;
using LoLHelper.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Xml.Linq;

namespace LoLHelper.Controllers
{
    public class UserBuildController:Controller
    {
        
        private readonly IDataProvider _provider;
        private readonly IPickBuilder _pickBuilder;
        private readonly ISortedPaginationBuilder _paginationBuilder;
        
       public UserBuildController(IDataProvider dataProvider,IPickBuilder pickBuilder, ISortedPaginationBuilder paginationBuilder)
        {            
            _provider = dataProvider;
            _pickBuilder = pickBuilder;
            _paginationBuilder = paginationBuilder;
             
        }
        public IActionResult UserBuild(SortState sortOrder = SortState.NameAsc, int page = 1)
        {
            var model = _provider.GetAllUserBuilds(User.FindFirstValue(ClaimTypes.NameIdentifier), "One");
            return View(_paginationBuilder.Create(sortOrder, page, model));
        }        
        public RedirectToRouteResult DelUserBuild(int id)
        {
            _pickBuilder.DeleteBuild(id);
            return RedirectToRoute(new { controller = "UserBuild", action = "UserBuild" });
        }
        public IActionResult AllUserBuild(SortState sortOrder = SortState.NameAsc, int page = 1)
        {
            var model = _provider.GetAllUserBuilds(User.FindFirstValue(ClaimTypes.NameIdentifier), "All");            
            return View(_paginationBuilder.Create(sortOrder, page, model));
        }
        public RedirectToRouteResult Like(int build)
        {
            var user = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (user == null)
            {
                return RedirectToRoute(new { controller = "Account", action = "login" });
            } 
            _provider.UpdateLike(user, build);
            return RedirectToRoute(new { controller = "UserBuild", action = "AllUserBuild" });
        }
        public IActionResult newLike(int build)
        {
            var user = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (user == null)
            {
                return RedirectToRoute(new { controller = "Account", action = "login" });
            }
            _provider.UpdateLike(user, build);
            return PartialView("_Like", _provider.GetLikes(User.FindFirstValue(ClaimTypes.NameIdentifier),build));           
        }
    }
}
