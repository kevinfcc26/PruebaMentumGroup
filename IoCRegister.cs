using Microsoft.Extensions.DependencyInjection;
using CustomerManager.Models;
using CustomerManager.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManager
{
    public static class IoCRegister
    {
        public static IServiceCollection AddRegistration(this IServiceCollection services)
        {
            AddRegisterRepositories(services);
            return services;
        }
        public static IServiceCollection AddRegisterRepositories(IServiceCollection services)
        {
            services.AddTransient<CustomerRepository>();
            

            return services;
        }
    }
}
