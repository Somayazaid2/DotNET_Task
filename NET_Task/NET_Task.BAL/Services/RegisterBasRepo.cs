using Microsoft.Extensions.DependencyInjection;
using NET_Task.BAL.Repository;
using NET_Task.DAL.BaseRepoInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Task.BAL.Services
{
    public static class RegisterBasRepo
    {
        public static IServiceCollection AddBaseRepo(this IServiceCollection services)
        {
            services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepo<>));
            return services;
        }
    }
}
