using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Store.Application.Interfaces;
using Store.Application.ViewModels;

namespace Store.PresentationLayer.Controllers
{
    public class StudentController : Controller
    {
        private IStudentService _service;
        public StudentController(IStudentService serviec)
        {
            _service = serviec;
        }
        public IActionResult Index()
        {
            StudentViewModel model = _service.GetStudents();
            return View(model);
        }
    }
}