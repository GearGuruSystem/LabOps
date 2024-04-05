using GG_LabOps_Domain.Interfaces;
using GG_LabOps_Infrastructure.Messages;
using GG_LabOps_Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace GG_LabOps_Infrastructure.InfrastructureModule
{
    public static class InfrastructureModule
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddRepositoryServices();
            services.AddMessageNotification();
            return services;
        }

        private static IServiceCollection AddRepositoryServices(this IServiceCollection services)
        {
            services.AddScoped<ILaboratoryRepository, LaboratoryRepository>();
            return services;
        }

        private static IServiceCollection AddMessageNotification(this IServiceCollection services)
        {
            services.AddScoped<IMessageNotificationService, RabbitMqService>();
            return services;
        }
    }
}
