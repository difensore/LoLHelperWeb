using DAL.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace LoLHelper.Interfaces
{
    public interface IIdentityProvider
    {
        public Task<Dictionary<IdentityResult, IdentityUser>> CreateUserAsync(RegisterViewModel model);
    }
}
