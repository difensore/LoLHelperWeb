using LoLHelper.Interfaces;
using LoLHelper.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using DAL.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace LoLHelper.Controllers

{
    public class AccountController:Controller
    {        
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly IIdentityProvider _identityprovider;              

        public AccountController(SignInManager<IdentityUser> signInManager, IIdentityProvider identityProvider)
        {            
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

                if (dictionary.ElementAt(0).Key.Succeeded)
                {                    
                    await _signInManager.SignInAsync(dictionary.ElementAt(0).Value, false);                   
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var error in dictionary.ElementAt(0).Key.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }
            return View(model);
        }

        
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result =
                    await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);
                if (result.Succeeded)
                {                   
                        return RedirectToAction("Index", "Home");                    
                }
                else
                {
                    ModelState.AddModelError("", "Wrong Login or Password");
                }
            }
            return View(model);
        }
        [Authorize]
        public async Task<IActionResult> LogOutAsync()
        { 
            await _signInManager.SignOutAsync();            
            return RedirectToAction("Index", "Home");
        }
    }
}
