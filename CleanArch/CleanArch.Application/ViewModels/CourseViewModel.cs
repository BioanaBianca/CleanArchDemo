using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Application.ViewModels
{
    public class CourseViewModel
    {

        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        /// <summary>
        /// Lista de cursuri.
        /// Face legatura cu Domain Layer
        /// </summary>
        public IEnumerable<Course> Courses { get; set; }
    }
}
