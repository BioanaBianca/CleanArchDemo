using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using CleanArch.Domain.Interfaces;
using CleanArch.Infrastructure.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Infrastructure.IoC
{
    public class DependencyContainer
    {
        //here will register evreything
        public static void RegisterServices(IServiceCollection services)
        {
            // Application Layer
            services.AddScoped<ICourseService, CourseService>();

            // Data Layer - Infrastructure Layer
            services.AddScoped<ICourseRepository, CourseRepository>();
        }
    }
}
