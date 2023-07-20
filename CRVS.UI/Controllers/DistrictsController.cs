using CRVS.Core.IRepositories;
using CRVS.Core.Models;
using CRVS.EF;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;


namespace CRVS.UI.Controllers
{
    public class DistrictsController : Controller
    {
        private readonly ApplicationDbContext db;
        public IBaseRepository<District> repository;
        public DistrictsController(IBaseRepository<District> _repository, ApplicationDbContext _db)
        {

            repository = _repository;
            db = _db;
        }
        public IActionResult Index()
        {

            return View(repository.GetAll());

        }
        /// <summary>
        /// /////////////////create governorate
        /// </summary>
        /// <returns></returns>
        public IActionResult Create()

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

            /// 
          

            return View();

        }
        [HttpPost]
        public IActionResult Create(District district)

        {

            repository.Add(district);

            return RedirectToAction(nameof(Index));

        }


        [HttpGet]
        public IActionResult Edit(int id)

        {
            List<Governorate> categorylist = new List<Governorate>();
            categorylist = db.Governorates.ToList();
            categorylist.Insert(0, new Governorate
            {
                GovernorateId = 0,
                GovernorateName = "يرجى اختيار المحافظة "
            });
            ViewBag.ListofGov = categorylist;


            if (id == null)
            {

                return RedirectToAction("Index");

            }
            var custom = repository.GetById(id);

            if (custom == null)
            {
                return RedirectToAction("NotFoundCustomer");
            }
            List<Doh> dohlist = new List<Doh>();
            dohlist = db.Dohs.Where(h => h.GovernorateId == custom.GovernorateId).ToList();

            ViewBag.Listdoh = dohlist;
          
            return View(custom);

        }


        [HttpPost]
        public IActionResult Edit(int id, District district)

        {
        //var data=    repository.GetById(id);
        //    data.GovernorateName = governorate.GovernorateName;
        repository.Update(id, district);
            //repository.SaveChanges();
          


            return RedirectToAction(nameof(Index));
        }




        [HttpGet]
        public IActionResult Delete(int id)
        {
            if (id == null || repository.GetById(id) == null)
            {
                return RedirectToAction(nameof(Index));
            }

           

            return View(repository.GetById(id));
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            repository.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int id)
        {
            if (id == null || repository.GetById(id) == null)
            {
                return RedirectToAction(nameof(Index));
            }



            return View(repository.GetById(id));
        }

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
    }


}





    
    