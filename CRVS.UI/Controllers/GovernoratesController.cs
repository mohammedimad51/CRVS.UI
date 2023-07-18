using CRVS.Core.IRepositories;
using CRVS.Core.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace CRVS.UI.Controllers
{
    public class GovernoratesController : Controller
    {
        public IBaseRepository<Governorate> repository;
        public GovernoratesController(IBaseRepository<Governorate> _repository)
        {

            repository = _repository;
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


            return View();

        }
        [HttpPost]
        public IActionResult Create(Governorate governorate)

        {

            repository.Add(governorate);

            return RedirectToAction(nameof(Index));

        }


        [HttpGet]
        public IActionResult Edit(int id)

        {



            if (id == null)
            {

                return RedirectToAction("Index");

            }
            var custom = repository.GetById(id);

            if (custom == null)
            {
                return RedirectToAction("NotFoundCustomer");
            }

            return View(custom);

        }


        [HttpPost]
        public IActionResult Edit(int id, Governorate governorate)

        {
        //var data=    repository.GetById(id);
        //    data.GovernorateName = governorate.GovernorateName;
        repository.Update(id, governorate);
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
    }


}





    
    