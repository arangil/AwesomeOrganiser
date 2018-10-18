using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using AwesomeOrganiser.Models;
using AwesomeOrganiser.ViewModels;

namespace AwesomeOrganiser.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITaskRepository _taskRepository;

        public HomeController(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public IActionResult Index()
        {
            var tasks = _taskRepository.GetAllTasks().OrderBy(t=>t.TaskTitle);

            var homeViewModel = new HomeViewModel()
            {
                PageTitle = "Task Organiser",
                Tasks = tasks.ToList()
            };

            return View(homeViewModel);
        }
        public IActionResult CreateTask()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateTask(Task task)
        {
            _taskRepository.AddTask(task);
            return RedirectToAction("Index");
        }
       
        public IActionResult EditTask(int taskid)
        {
            var task = _taskRepository.GetTaskById(taskid);
            return View(task);
        }
        public IActionResult EditTask2(int id)
        {
            var task = _taskRepository.GetTaskById(id);
            return View("EditTask", task);
        }


        [HttpPost]
        public IActionResult EditTask(Task task)
        {
            _taskRepository.UpdateTask(task);
            return RedirectToAction("Index");
        }


        public IActionResult Details(int id)
        {
            var task = _taskRepository.GetTaskById(id);
            if (task == null)  return NotFound();

            return View(task);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
