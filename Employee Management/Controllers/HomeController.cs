using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Employee_Management.Models;
using Employee_Management.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Employee_Management.Controllers
{
    public class HomeController : Controller
    {
        private IEmployeeRepository _employeeRepository;
        private readonly IHostingEnvironment hostingEnvironment;
        private readonly IPositionRepository positionRepository;
        private readonly IScheduleRepository scheduleRepository;
        private readonly IProjecttRepository ProjecttRepository;

        public HomeController(IEmployeeRepository employeeRepository,IHostingEnvironment hostingEnvironment,
                                IPositionRepository positionRepository, IScheduleRepository scheduleRepository,
                                IProjecttRepository ProjecttRepository)
        {
            _employeeRepository = employeeRepository;
            this.hostingEnvironment = hostingEnvironment;
            this.positionRepository = positionRepository;
            this.scheduleRepository = scheduleRepository;
            this.ProjecttRepository = ProjecttRepository;
        }
        public IActionResult Delete(int id)
        {
            _employeeRepository.Delete(id);
            return RedirectToAction("Index");
        }

        public ViewResult Index()
        {
            

            var model = _employeeRepository.GetAllEmployee();
            return View(model);
        }
        public ViewResult CreateR()
        {


            return View();
        }

        public ViewResult Details(int? id)
        {
            
            Employee model = _employeeRepository.GetEmployee(id.Value);
            if (model == null)
            {
                Response.StatusCode = 404;
                return View("EmployeeNotFound", id.Value);
            }
            return View(model);
        }
        [HttpGet]
        public ViewResult Create()
        {
            EmployeeCreateViewModel model = new EmployeeCreateViewModel();

            model.PositionList = positionRepository.GetAllPosition();
            model.ScheduleList = scheduleRepository.GetAllSchedule().Select(a => new SelectListItem()
            {
                Value = a.ScheduleId.ToString(),
                Text = a.TimeIn + '-' + a.TimeOut
            }).ToList();
            model.ProjecttList = ProjecttRepository.GetAllProjectt();

            return View(model);
        }

        [HttpPost]
        public IActionResult Create(EmployeeCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = processFile(model);
                Projectt Projectt = ProjecttRepository.GetProjectt(model.ProjecttID);
                Position position = positionRepository.GetPosition(model.PositionID);
                Schedule schedule = scheduleRepository.GetSchedule(model.ScheduleID);

                Employee newEmployee = new Employee
                {
                    Name = model.Name,
                    Email = model.Email,
                    Projectt = Projectt,
                    Position = position,
                    Schedule = schedule,
                    PhotoPath = uniqueFileName
                };


                _employeeRepository.Add(newEmployee);
                return RedirectToAction("Index");
            }

            return View();
        }

        private string processFile(EmployeeCreateViewModel model)
        {
            string uniqueFileName = null;
            if (model.Photo != null)
            {
                string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Photo.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using(var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.Photo.CopyTo(fileStream);
                }
                    
            }

            return uniqueFileName;
        }

        [HttpGet]
        public ViewResult Edit(int id)
        {
            Employee employee = _employeeRepository.GetEmployee(id);
            EmployeeEditViewModel employeeEditViewModel = new EmployeeEditViewModel
            {
                ID = employee.ID,
                Name = employee.Name,
                Email = employee.Email,
                //PositionList= (IEnumerable<Position>)employee.Position,
                //Projectt = employee.Projectt,
                
                ExistingPhotoPath = employee.PhotoPath
            };

            return View(employeeEditViewModel);
        }




        [HttpPost]
        public IActionResult Edit(EmployeeEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                Employee employee = _employeeRepository.GetEmployee(model.ID);
                employee.Name = model.Name;
                employee.Email = model.Email;
                //employee.Projectt = model.Projectt;
                if(model.Photo != null)
                {
                    if(model.ExistingPhotoPath != null)
                    {
                        string filePath = Path.Combine(hostingEnvironment.WebRootPath, "images", model.ExistingPhotoPath);
                        System.IO.File.Delete(filePath);
                    }

                    employee.PhotoPath = processFile(model);
                }

                _employeeRepository.Update(employee);
                return RedirectToAction("Index");
            }
            return View();
        }

    }
}