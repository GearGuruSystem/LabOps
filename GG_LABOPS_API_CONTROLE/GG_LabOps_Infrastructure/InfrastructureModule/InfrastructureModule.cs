using GG_LabOps_Domain.Interfaces;
using GG_LabOps_Infrastructure.DataAcess;
using GG_LabOps_Infrastructure.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace GG_LabOps_Infrastructure.InfrastructureModule
{
    public static class InfrastructureModule
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddRepositoryServices();
            services.AddSqlDataService();
            return services;
        }

        private static IServiceCollection AddRepositoryServices(this IServiceCollection services)
        {
            services.AddScoped<ILaboratoryRepository, LaboratoryRepository>();
            services.AddScoped<IEquipamentRepository, EquipamentRepository>();
            return services;
        }

        private static IServiceCollection AddSqlDataService(this IServiceCollection services)
        {
            services.AddSingleton<ISqlDataAcess, SqlDataAcess>();
            services.AddSingleton<ISqlFactory, SqlFactory>();
            return services;
        }
    }
}
