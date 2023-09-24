using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using NET_Task.BAL.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Task.BAL.Services
{
    public static class RegisterAutoMapper
    {
        public static IServiceCollection AddAutoMapper(this IServiceCollection services)
        {
            var config = new MapperConfiguration(Mcf =>
            {
                Mcf.AddProfile(new DomainProfile());
            });
            var Mapper = config.CreateMapper();
            services.AddSingleton(Mapper);

            return services;
        }
    }
}
