using GG_LabOps_Domain.Interfaces;
using GG_LabOps_Infra.Persistence.ApiClients;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GG_LabOps_Infra.InfrastructureModule
{
    public static class InfrastructureModule
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddApiClientsServices(configuration);
            services.AddSqlDataService();

            return services;
        }

        private static IServiceCollection AddApiClientsServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddHttpClient<IUserApiClient, UserApiClient>(x => x.BaseAddress = new Uri(configuration["ServiceUrls:UserAPI"]));

            return services;
        }

        private static IServiceCollection AddSqlDataService(this IServiceCollection services)
        {
            return services;
        }
    }
}
