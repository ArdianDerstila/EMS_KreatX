using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Employee_Management.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Employee_Management.Controllers
{
    public class ProjecttController : Controller
    {
        private readonly IProjecttRepository ProjecttRepository;

        public ProjecttController(IProjecttRepository ProjecttRepository)
        {
            this.ProjecttRepository = ProjecttRepository;
        }

        public IActionResult Index()
        {
            var model = ProjecttRepository.GetAllProjectt();
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            Projectt Projectt = new Projectt();
            return PartialView("Create", Projectt);
        }

        [HttpPost]
        public IActionResult Create(Projectt Projectt)
        {
            if (ModelState.IsValid)
            {
                ProjecttRepository.Add(Projectt);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var Projectt = ProjecttRepository.GetProjectt(id);
            return PartialView("Edit", Projectt);
        }

        [HttpPost]
        public IActionResult Edit(Projectt Projectt)
        {
            ProjecttRepository.Update(Projectt);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            ProjecttRepository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}