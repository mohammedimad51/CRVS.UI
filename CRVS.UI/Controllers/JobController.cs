﻿using CRVS.Core.IRepositories;
using CRVS.Core.Models;
using CRVS.EF;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
