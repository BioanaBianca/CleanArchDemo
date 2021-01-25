using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Application.ViewModels
{
    public class CourseViewModel
    {
        /// <summary>
        /// Lista de cursuri.
        /// Face legatura cu Domain Layer
        /// </summary>
        public IEnumerable<Course> Courses { get; set; }
    }
}
