using Application.Interfaces.Repositories.Common;
using Application.UnitOfWorkService;
using Data.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Repositories.Commmon;
using Infrastructure.Interfaces.Repositories.Common;


namespace Application.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddProjectServices(this IServiceCollection services, ConfigurationManager configuration)
        {
            var connection = configuration.GetConnectionString("gaadiyaDekhoConnection");

            services.AddDbContext<gaadiyadekhoContext>(options =>
            {
                options.UseSqlServer(connection);
            });

            services.AddScoped<IBaseRepository<T>, BaseRepository<T>>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

        }
    }
}
