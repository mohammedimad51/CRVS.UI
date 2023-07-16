using CRVS.Core.Models;
using CRVS.Core.Models.ViewModels;
using CRVS.EF;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CRVS.UI.Controllers
{
    [Authorize]
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

            List<Governorate> categorylist = new List<Governorate>();
            categorylist = db.Governorates.ToList();
            categorylist.Insert(0, new Governorate
            {
                GovernorateId = 0,
                GovernorateName = "يرجى اختيار المحافظة "
            });
            ViewBag.ListofGov = categorylist;
            /////////
            /// 
            List<FacilityType> facilityTypelist = new List<FacilityType>();
            facilityTypelist = db.FacilityTypes.ToList();
            facilityTypelist.Insert(0, new FacilityType
            {
                FacilityTypeId = 0,
                FacilityTypeName = "يرجى اختيار نوع المؤسسة"
            });
            ViewBag.ListofFacilityType = facilityTypelist;

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
                     Img= model.Img,
                     IsBlocked=false,
                     RegisterDate = DateTime.Now,
                     Governorate= model.Governorate,
                     Doh= model.Doh,
                     District= model.District,
                     Nahia= model.Nahia,
                     Village= model.Village,
                     FacilityType= model.FacilityType,
                     HealthInstitution= model.HealthInstitution

                    };
                    db.Users.Add(userInf);
                    db.SaveChanges();

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
                ViewBag.login = "mohammed imad";
                string id = userManager.GetUserId(HttpContext.User)!;
                if (result.Succeeded)
                {

                  
                    var userInfo = db.Users.Where(c => c.UserId == id).FirstOrDefault();
                    ViewBag.FullName = userInfo!.FName + " " + userInfo.LName;
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Wrong User Name or Password");
                return View(model);
            }
            return View(model);
        }

        /// <summary>
        /// /////////////////////////
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Lock(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(
                        model.UserEmail!,
                        model.Password!,
                        model.RememberMe,
                        false);
                ViewBag.login = "mohammed imad";
                string id = userManager.GetUserId(HttpContext.User)!;
                if (result.Succeeded)
                {


                    var userInfo = db.Users.Where(c => c.UserId == id).FirstOrDefault();
                    ViewBag.FullName = userInfo!.FName + " " + userInfo.LName;
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Wrong User Name or Password");
                return View(model);
            }
            return View(model);
        }
        /// </summary>
        /// <returns></returns>

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        #endregion


        #region Cascading

        [AllowAnonymous]
        public JsonResult GetDoh(int GovernorateId)
        {
            List<Doh> subDohList = new List<Doh>();

            subDohList = (from Doh in db.Dohs
                          where
                         Doh.GovernorateId == GovernorateId
                          select Doh).ToList();
            subDohList.Insert(0, new Doh { DohId = 0, DohName = "يرجى اختيار دائرة الصحة" });
            return Json(new SelectList(subDohList, "DohId", "DohName"));

        }
        [AllowAnonymous]

        public JsonResult GetHealthInstitution(int DohId)
        {
            List<HealthInstitution> HealthInstitutionList = new List<HealthInstitution>();

            HealthInstitutionList = (from HealthInstitution in db.HealthInstitutions
                                     where
                           HealthInstitution.DohId == DohId    
                                     select HealthInstitution).ToList();
            HealthInstitutionList.Insert(0, new HealthInstitution { HealthInstitutionId = 0, HealthInstitutionName = "يرجة اختيار اسم المؤسسة" });
            return Json(new SelectList(HealthInstitutionList, "HealthInstitutionId", "HealthInstitutionName"));

        }
        [AllowAnonymous]
        public JsonResult GetDistrict(int GovernorateId)
        {
            List<District> subDistrictList = new List<District>();

            subDistrictList = (from District in db.Districts
                               where
                         District.GovernorateId == GovernorateId
                          select District).ToList();
            subDistrictList.Insert(0, new District { DistrictId = 0, DistrictName = "يرجى اختيار القضاء" });
            return Json(new SelectList(subDistrictList, "DistrictId", "DistrictName"));

        }
        [AllowAnonymous]
        public JsonResult GetNahia(int DistrictId)
        {
            List<Nahia> subNahiaList = new List<Nahia>();

            subNahiaList = (from Nahia in db.Nahias
                               where
                         Nahia.DistrictId == DistrictId
                               select Nahia).ToList();
            subNahiaList.Insert(0, new Nahia { NahiaId = 0, NahiaName = "يرجى اختيار الناحية" });
            return Json(new SelectList(subNahiaList, "NahiaId", "NahiaName"));

        }

        #endregion







    }
}
