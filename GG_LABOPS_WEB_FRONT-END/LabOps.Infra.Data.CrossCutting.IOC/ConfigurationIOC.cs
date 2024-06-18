using LabOps.Application.Interfaces;
using LabOps.Infra.ControlApi.Services;
using LabOps.Infra.Data.AuthApi.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LabOps.Infra.Data.CrossCutting.IOC
{
    public static class ConfigurationIOC
    {
        public static IServiceCollection DependencyInjected(this IServiceCollection services, IConfiguration configuration)
        {
            #region Registra IOC 

            #region IOC Application
            services.AddScoped<IServiceAuth, ServiceAuth>();
            services.AddScoped<IServiceFabricante, ServiceFabricante>();
            #endregion

            #region IOC Infrastructure
            services.AddHttpClient<IServiceAuth, ServiceAuth>(x => x.BaseAddress = new Uri(configuration["ServiceUrls:ApiAuth"]));
            services.AddHttpClient<IServiceFabricante, ServiceFabricante>(x => x.BaseAddress = new Uri(configuration["ServiceUrls:ApiControl"]));
            #endregion

            #endregion
            return services;
        }
    }
}
