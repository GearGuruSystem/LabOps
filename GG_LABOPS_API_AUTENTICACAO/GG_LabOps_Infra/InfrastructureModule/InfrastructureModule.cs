using GG_LabOps_Infra.DBAcess;
using GG_LabOps_Infra.Persistence.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace GG_LabOps_Infra.InfrastructureModule
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
            services.AddScoped<IUserRepository, UserRepository>();
            return services;
        }

        private static IServiceCollection AddSqlDataService(this IServiceCollection services)
        {
            services.AddSingleton<ISqlFactory, SqlFactory>();
            return services;
        }
    }
}