using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Pronia.Models;
using Pronia.ViewModels.Account;

namespace Pronia.Controllers
{
    public class AccountController : Controller
    {
        UserManager<AppUser> _userManager;

        public AccountController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterVm registerVm)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }


            AppUser appUser = new AppUser()
            {
                Name = registerVm.Name,
                Email = registerVm.Email,
                Surname = registerVm.Surname,
                UserName = registerVm.Username,
            };


            var result= await _userManager.CreateAsync(appUser, registerVm.Password);
            if (!result.Succeeded)
            {
                foreach(var item in result.Errors)
                {
                    ModelState.AddModelError("",item.Description);
                }
                return View();
            }

            return RedirectToAction("Index", "Home");
        }
    }
}
