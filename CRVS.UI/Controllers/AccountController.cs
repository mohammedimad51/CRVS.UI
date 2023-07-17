using CRVS.Core.Models;
using CRVS.Core.Models.ViewModels;
using CRVS.EF;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Diagnostics;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CRVS.UI.Controllers
{
 
    public class AccountController : Controller
    {
    
        private UserManager<IdentityUser> userManager;
        private SignInManager<IdentityUser> signInManager;
        private readonly ApplicationDbContext db;
        private RoleManager<IdentityRole> roleManager;
        public AccountController(UserManager<IdentityUser> _userManager,

                SignInManager<IdentityUser> _signInManager
            , ApplicationDbContext _db, RoleManager<IdentityRole> _roleManager)
        {
            userManager = _userManager;
            signInManager = _signInManager;
                      db = _db;
            roleManager = _roleManager;
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
                     Doh = model.Doh ,
                    District = model.District,
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
               
                if (result.Succeeded)
                {
                    var inf = await userManager.FindByEmailAsync(model.UserEmail);
                    String y = inf.Id;
                    var userInfo = db.Users.Where(c => c.UserId == y).FirstOrDefault();
                    //ViewBag.FullName = userInfo!.FName + " " + userInfo.LName;

                   HttpContext.Session.SetString("name", userInfo!.FName + " " + userInfo.LName);
                    HttpContext.Session.SetString("mail", userInfo!.Email);
                    

                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Wrong User Name or Password");
                return View(model);
            }
            return View(model);
        }



        /// <summary>
        /// /////////////////////////
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Lock( )
        {
           

            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Lock (LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                string infEmail = HttpContext.Session.GetString("mail")!;
                var result = await signInManager.PasswordSignInAsync(



                   infEmail,
                        model.Password!, 
                        model.RememberMe,
                        false);
               
                if (result.Succeeded)
                {
                    var inf = await userManager.FindByEmailAsync(model.UserEmail);
                    String y = inf.Id;
                    var userInfo = db.Users.Where(c => c.UserId == y).FirstOrDefault();
                    //ViewBag.FullName = userInfo!.FName + " " + userInfo.LName;

                   HttpContext.Session.SetString("name", userInfo!.FName + " " + userInfo.LName);
                    HttpContext.Session.SetString("mail", userInfo!.Email);
                    

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
        [AllowAnonymous]
        public async Task<IActionResult> Logout()
        {
            
            await signInManager.SignOutAsync();

            return RedirectToAction("Lock", "Account");

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

        public JsonResult GetHealthInstitution(int DohId , int FacilityTypeId)
        {
            List<HealthInstitution> HealthInstitutionList = new List<HealthInstitution>();

            HealthInstitutionList = (from HealthInstitution in db.HealthInstitutions
                                     where
                           HealthInstitution.DohId == DohId && HealthInstitution.FacilityTypeId == FacilityTypeId
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

        #region Roles
        [HttpGet]
        [AllowAnonymous]
        public IActionResult AllUsers()
        {

            ViewBag.user = db.Users.ToList();

            return View();
        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult RolesList()
        {
            ViewBag.roleList = db.Roles.ToList();
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> EditRole(string? id)
        {
            var roleData = await roleManager.FindByIdAsync(id!);
            if (roleData == null)
            {
                return RedirectToAction(nameof(RolesList));
            }
            EditRoleViewModel model = new EditRoleViewModel
            {
                RoleId = roleData.Id,
                RoleName = roleData.Name


            };
            foreach (var user in userManager.Users)
            {
                if (await userManager.IsInRoleAsync(user, model.RoleName!))
                {
                    model.Users!.Add(user.UserName!);
                }
            }
          
            return View(model);
        }

       
        [HttpPost]
        public async Task<IActionResult> EditRole(EditRoleViewModel model)
             
        {
            if (ModelState.IsValid)
            {
                var role = await roleManager.FindByIdAsync(model.RoleId!);
                if (role == null)
                {
                    return RedirectToAction(nameof(RolesList));

                };
                role.Name = model.RoleName;

                var result = await roleManager.UpdateAsync(role);
                if (result.Succeeded)
                {
                    return RedirectToAction(nameof(RolesList));
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
        public IActionResult CreateRole()
        { return View(); }


        [HttpPost]
     
        public async Task<IActionResult> CreateRole(CreateRoleViewModel model)
        {

            if (ModelState.IsValid)
            {
                IdentityRole roleName = new IdentityRole

                {
                    Name = model.CreateRoleName,

                };
                var result = await roleManager.CreateAsync(roleName);
                if (result.Succeeded)
                {
                    return RedirectToAction("RolesList", "Account");
                }
                foreach (var err in result.Errors)
                {
                    ModelState.AddModelError(err.Code, err.Description);
                }
                return View(model);

            }
            return View(model);

        }
     
        public async Task<IActionResult> DeleteRole(string? id)
        {
            var roleData = await roleManager.FindByIdAsync(id!);
            if (roleData != null)
            {
                var result = await roleManager.DeleteAsync(roleData);

                if (result.Succeeded)
                {
                    return RedirectToAction("RolesList", "Account");
                }
                foreach (var err in result.Errors)
                {
                    ModelState.AddModelError(err.Code, err.Description);
                }
            }
            return RedirectToAction("RolesList", "Account");
        }
        [HttpGet]
      
        public async Task<IActionResult> AddRemoveUserRole(string? id)
        {
            var role = await roleManager.FindByIdAsync(id!);
            if (role == null)
            {
                return RedirectToAction(nameof(NotFoundData));
            }
            if (id == null) { return RedirectToAction(nameof(NotFoundData)); }
            var userRole = new List<AddRemoveUserRoleViewModel>();
            foreach (var uRole in userManager.Users)
            {
                var model = new AddRemoveUserRoleViewModel
                {
                    UserName = uRole.UserName,
                    UserId = uRole.Id
                };
                if (await userManager.IsInRoleAsync(uRole, role.Name!))
                {
                    model.IsSelected = true;

                }

                else
                {
                    model.IsSelected = false;
                }
                userRole.Add(model);

            }
            return View(userRole);
        }
       
        [HttpPost]
        public async Task<IActionResult> AddRemoveUserRole(List<AddRemoveUserRoleViewModel> models, string? id)
        {
            var role = await roleManager.FindByIdAsync(id!);
            if (role == null)
            {
                return RedirectToAction(nameof(NotFoundData));
            }
            if (id == null)
            {
                return RedirectToAction(nameof(NotFoundData));
            }
            IdentityResult result = null;
            for (int i = 0; i < models.Count; i++)
            {
                var user = await userManager.FindByIdAsync(models[i].UserId!);
                if (models[i].IsSelected == true && !(await userManager.IsInRoleAsync(user!, role.Name!)))
                {
                    result = await userManager.AddToRoleAsync(user!, role.Name!);
                }
                else if (!models[i].IsSelected == true && (await userManager.IsInRoleAsync(user!, role.Name!)))
                {
                    result = await userManager.RemoveFromRoleAsync(user!, role.Name!);
                }
            }
            return RedirectToAction(nameof(RolesList));
        }


        public IActionResult NotFoundData()
        {
            //ViewBag.ErrorItem = "NotFound";
            return View();
        }

        public IActionResult AccessDenied()
        {
            //ViewBag.ErrorItem = "NotFound";
            return View();
        }




        #endregion





    }
}
