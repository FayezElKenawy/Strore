using Microsoft.Extensions.DependencyInjection;
using Store.Application.Interfaces;
using Store.Domain.Interfaces;
using Store.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Infra.Ioc
{
    public class DependencyContainer
    {
        public static void ServiceRegister(IServiceCollection Services)
        {
            Services.AddScoped<IStudentService, IStudentService>();
            Services.AddScoped<IStudentRepository, StudentRepository>();
        }
    }
}
