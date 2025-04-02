using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcommerceWebAPI.Persistence.Context;
using EcommerceWebAPI.Application.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using EcommerceWebAPI.Persistence.Repositories;
using EcommerceWebAPI.Application.Interfaces.UnitOfWorks;
using EcommerceWebAPI.Persistence.UnitOfWorks;

namespace EcommerceWebAPI.Persistence
{
    public static class Registration
    {
        public static void AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(opt =>
            opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped(typeof(IReadRepository<>), typeof(ReadRepository<>));
            services.AddScoped(typeof(IWriteRepository<>), typeof(WriteRepository<>));

            services.AddScoped<IUnitOfWork, UnitOfWork>();

        }
    }
}
