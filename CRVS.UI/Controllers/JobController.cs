using CRVS.Core.IRepositories;
using CRVS.Core.Models;

using Microsoft.AspNetCore.Mvc;


namespace CRVS.UI.Controllers
{
    public class JobController : Controller
    {
        public IBaseRepository<Job> repository;
        public JobController(IBaseRepository<Job> _repository)
        {

            repository = _repository;
        }
        public IActionResult Index()
        {
            
            return View(repository.GetAll());

        }
        public IActionResult Create()

        {


            return View();

        }
        [HttpPost]
        public IActionResult Create(Job job)

        {
           
                repository.Add(job);
           
                return RedirectToAction(nameof(Index));
           
        }
    }
}
