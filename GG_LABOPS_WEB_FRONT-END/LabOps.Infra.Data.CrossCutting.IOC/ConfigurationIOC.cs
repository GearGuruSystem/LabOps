using LabOps.Application.Interfaces.ApiAutenticacao;
using LabOps.Application.Interfaces.ApiControle;
using LabOps.Infra.ControlApi.Services;
using LabOps.Infra.Data.AuthApi.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Net.Http.Headers;

namespace LabOps.Infra.Data.CrossCutting
{
    public static class ConfigurationIOC
    {
        public static IServiceCollection DependencyInjected(this IServiceCollection services, IConfiguration configuration)
        {
            #region IOC Application

            services.AddScoped<IServiceAuth, ServiceAuth>();
            services.AddScoped<IServicesFabricante, ServicesFabricante>();
            services.AddScoped<IServicesEquipamento, ServicesEquipamento>();

            #endregion IOC Application

            #region IOC Infrastructure HttpClient

            services.AddHttpClient("ApiAuth", opts =>
            {
                opts.BaseAddress = new Uri(configuration["ServiceUrls:ApiAuth"]);
                opts.DefaultRequestHeaders.Add(HeaderNames.Accept, "application/json");
            });

            services.AddHttpClient("ApiControl", opts =>
            {
                opts.BaseAddress = new Uri(configuration["ServiceUrls:ApiControl"]);
                opts.DefaultRequestHeaders.Add(HeaderNames.Accept, "application/json");
            });

            #endregion IOC Infrastructure HttpClient

            return services;
        }
    }
}