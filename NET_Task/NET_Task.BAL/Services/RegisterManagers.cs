using Microsoft.Extensions.DependencyInjection;
using NET_Task.BAL.Managers;
using NET_Task.BAL.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Task.BAL.Services
{
    public static class RegisterManagers
    {
        public static IServiceCollection AddManagersServices(this IServiceCollection services)
        {
            
            services.AddScoped<IProgramDetailsRepo, ProgramDetailsManager>();
            

            return services;
        }
    }
}
