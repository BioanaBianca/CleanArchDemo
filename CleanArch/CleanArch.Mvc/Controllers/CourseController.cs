using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CleanArch.Mvc.Controllers
{
    [Authorize]
    public class CourseController : Controller
    {
        private ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            // inject the service
            _courseService = courseService;
        }

        public IActionResult Index()
        {
            //reference to our VM
            CourseViewModel model = _courseService.GetCourses();

            //return the VM to the view
            return View(model);
        }
    }
}
