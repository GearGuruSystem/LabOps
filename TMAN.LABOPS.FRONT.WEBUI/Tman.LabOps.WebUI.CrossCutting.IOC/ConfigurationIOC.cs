using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Net.Http.Headers;
using Tman.LabOps.Infrastructure.CrossCutting.Interfaces;
using Tman.LabOps.Infrastructure.Data.ControlApi.Services;
using Tman.LabOps.WebUI.Application.Handlers;
using Tman.LabOps.WebUI.Application.Interfaces;

namespace Tman.LabOps.WebUI.CrossCutting.IOC
{
    public static class ConfigurationIOC
    {
        public static IServiceCollection AddServicesInjected(this IServiceCollection services, IConfiguration configuration)
        {
            #region IOC
            #region IOC Services
            services.AddScoped<IServicesEquipment, ServicesEquipment>();
            services.AddScoped<IServicesManufacturer, ServicesManufacturer>();
            services.AddScoped<IServicesEquipmentType, ServicesEquipmentType>();
            services.AddScoped<IServicesSituation, ServicesSituation>();
            #endregion IOC Services

            #region IOC Handlers
            services.AddScoped<IHandlersEquipment, HandlersEquipment>();
            services.AddScoped<IHandlerManufacturer, HandlerManufacturer>();
            services.AddScoped<IHandlerEquipmentType, HandlerEquipmentType>();
            services.AddScoped<IHandlerSituation, HandlerSituation>();
            #endregion IOC Handlers

            #region IOC HttpClient
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
            #endregion IOC HttpClient
            #endregion IOC

            return services;
        }
    }
}
