using AutoMapper;
using LabOps.Infra.ControlApi.Services;
using LabOps.Infra.Data.AuthApi.Services;
using LabOps.Infra.Data.CrossCutting.Adapter.Interfaces.ApiAutenticacao;
using LabOps.Infra.Data.CrossCutting.Adapter.Interfaces.ApiControle;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Net.Http.Headers;

namespace LabOps.Infra.Data.CrossCutting
{
    public static class ConfigurationIOC
    {
        public static IServiceCollection AddServicesInjected(this IServiceCollection services, IConfiguration configuration)
        {
            #region IOC Services

            services.AddScoped<IServiceAuth, ServiceAuth>();
            services.AddScoped<IServicesEquipament, ServicesEquipamento>();
            services.AddScoped<IServicesFabricante, ServicesFabricante>();
            services.AddScoped<IServicesTipoEquipamento, ServicesTipoEquipamento>();
            services.AddScoped<IServicesSituacao, ServicesSituacao>();

            #endregion IOC Services

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