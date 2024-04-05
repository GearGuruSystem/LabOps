using GG_LabOps_Domain.Interfaces;
using GG_LabOps_Infrastructure.DataContext;
using GG_LabOps_Infrastructure.Persistence.DataAcess;
using GG_LabOps_Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GG_LabOps_Infrastructure.InfrastructureModule
{
    public static class InfrastructureModule
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSqlDataServer(configuration);
            services.AddRepositoryServices();
            services.AddSqlDataService();
            return services;
        }

        private static IServiceCollection AddRepositoryServices(this IServiceCollection services)
        {
            services.AddScoped<ILaboratoryRepository, LaboratoryRepository>();
            return services;
        }

        private static IServiceCollection AddSqlDataService(this IServiceCollection services)
        {
            services.AddSingleton<ISqlDataAcess, SqlDataAcess>();
            return services;
        }

        private static IServiceCollection AddSqlDataServer(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApiDataContext>(opts => opts.UseSqlServer(
                configuration.GetConnectionString("SqlDataLocal")));
            return services;
        }
    }
}
