using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Tman.LabOps.WebUI.Application.Adapter;
using Tman.LabOps.WebUI.Application.Interfaces;
using Tman.LabOps.WebUI.Application.Services;

namespace Tman.LabOps.WebUI.CrossCutting
{
    public static class ConfigurationIOC
    {
        public static IServiceCollection AddConfigurationServices(this IServiceCollection services)
        {
            #region IOC Services

            services.AddTransient<IServiceFabricante, ServiceFabricante>();
            services.AddTransient<IServiceTipoEquipamento, ServiceTipoEquipamento>();
            services.AddTransient<IServiceEquipamento, ServiceEquipamento>();

            #endregion IOC Services

            #region IOC Mapper

            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MapperEquipamento());
            });
            var mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            #endregion IOC Mapper

            return services;
        }
    }
}