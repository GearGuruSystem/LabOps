using GG_LabOps_Domain.Interfaces;
using GG_LabOps_Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace GG_LabOps_Infrastructure.InfrastructureModule
{
    public static class InfrastructureModule
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddRepositoryServices();
            return services;
        }

        private static IServiceCollection AddRepositoryServices(this IServiceCollection services)
        {
            services.AddScoped<ILaboratoryRepository, LaboratoryRepository>();
            return services;
        }
    }
}
