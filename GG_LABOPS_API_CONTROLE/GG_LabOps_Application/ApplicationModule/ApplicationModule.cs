using GG_LabOps_Application.Services;
using GG_LabOps_Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace GG_LabOps_Application.ApplicationModule
{
    public static class ApplicationModule
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddApplicationService();
            return services;
        }

        private static IServiceCollection AddApplicationService(this IServiceCollection services)
        {
            services.AddScoped<ILaboratoryServices, LaboratoryServices>();
            services.AddScoped<IEquipamentService, EquipamentServices>();
            return services;
        }
    }
}
