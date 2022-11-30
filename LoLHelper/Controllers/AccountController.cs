using LoLHelper.Interfaces;
using LoLHelper.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using DAL.ViewModels;

namespace LoLHelper.Controllers

{
    public class AccountController:Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly IIdentityProvider _identityprovider;

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, IIdentityProvider identityProvider)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _identityprovider = identityProvider;
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var dictionary = _identityprovider.CreateUserAsync(model).Result;

                if (dictionary.ElementAt(1).Key.Succeeded)
                {
                    // установка куки
                    await _signInManager.SignInAsync(dictionary.ElementAt(1).Value, false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var error in dictionary.ElementAt(1).Key.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }
            return View(model);
        }
    }
}
