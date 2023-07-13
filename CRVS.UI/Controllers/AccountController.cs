using CRVS.Core.Models;
using CRVS.Core.Models.ViewModels;
using CRVS.EF;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CRVS.UI.Controllers
{
    public class AccountController : Controller
    {
    
        private UserManager<IdentityUser> userManager;
        private SignInManager<IdentityUser> signInManager;
        private readonly ApplicationDbContext db;
        public AccountController(UserManager<IdentityUser> _userManager,

                SignInManager<IdentityUser> _signInManager
            , ApplicationDbContext _db)
        {
            userManager = _userManager;
            signInManager = _signInManager;
                      db = _db;
        }
        #region AuthN&AuthiZ

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }

        
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                IdentityUser user = new IdentityUser
                {
                    UserName = model.UserEmail,
                    Email = model.UserEmail,
                    PhoneNumber = model.Phone,
                 
                };
               

                var result = await userManager.CreateAsync(user, model.Password!);
                if (result.Succeeded)

                   

                {
                    User userInf = new User
                    {
                     UserId = user.Id,
                     Email = model.UserEmail,
                     Phone = model.Phone,
                     FName= model.FName,
                     LName= model.LName,


                    };
                    return RedirectToAction("Login", "Account");
                }
                foreach (var err in result.Errors)
                {
                    ModelState.AddModelError(err.Code, err.Description);
                }
                return View(model);
            }
            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(
                        model.UserEmail!,
                        model.Password!, 
                        model.RememberMe,
                        false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Wrong User Name or Password");
                return View(model);
            }
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
#endregion





        public IActionResult Index()
        {
            return View();
        }
    }
}
