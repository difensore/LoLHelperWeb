using DAL.ViewModels;
using LoLHelper.Interfaces;
using LoLHelper.Models;
using Microsoft.AspNetCore.Identity;
using System.Security.Principal;

namespace LoLHelper.Services
{
    public class IdentityProvider:IIdentityProvider
    {
        private readonly LolHelperContext db;
        private readonly UserManager<IdentityUser> _userManager;
        public IdentityProvider(LolHelperContext context, UserManager<IdentityUser> userManager)
        {
            db = context;
            _userManager = userManager;
        }
        public async Task<Dictionary<IdentityResult, IdentityUser>> CreateUserAsync(RegisterViewModel model)
        {
            IdentityUser user = new IdentityUser { Email = model.Email, UserName = model.Email };
            // добавляем пользователя
            var result = await _userManager.CreateAsync(user, model.Password);
            Dictionary<IdentityResult, IdentityUser> dictionary = new Dictionary<IdentityResult, IdentityUser>();
            dictionary.Add(result, user);
            return dictionary;
        }
    }
}
