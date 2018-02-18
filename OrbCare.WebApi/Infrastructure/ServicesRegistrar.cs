using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OrbCare.Infrastructure;
using OrbCare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrbCare.WebApi.Infrastructure
{
    public class ServicesRegistrar
    {
        public static void Register(IServiceCollection services)
        {
            services.AddTransient(typeof(IRepository<>),typeof(Repository<>));
            services.AddTransient(typeof(IDbService<>), typeof(DbService<>));
            services.AddTransient<IUnitOfWork,UnitOfWork>();
            services.AddTransient<DbContext, PariscribeContext>();
        }
    }
}
