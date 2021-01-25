using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Infrastructure.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        // injection with Context
        private UniversityDBContext _ctx;

        //injecton in constructor
        public CourseRepository(UniversityDBContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<Course> GetCourses()
        {
            return _ctx.Courses;
        }
    }
}
