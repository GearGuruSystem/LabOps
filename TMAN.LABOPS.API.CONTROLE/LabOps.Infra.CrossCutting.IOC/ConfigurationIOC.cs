using AutoMapper;
using LabOps.Application.Interfaces;
using LabOps.Application.Service;
using LabOps.Domain.Core.Interfaces;
using LabOps.Domain.Core.Services;
using LabOps.Domain.Services.Services;
using LabOps.Infra.Data.DataAcess;
using LabOps.Infra.Data.DataContext;
using LabOps.Infra.Repository.Repository;
using LabOps.Infrastructure.CrossCutting.Adapter.Map;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LabOps.Infra.CrossCutting.IOC
{
    public static class ConfigurationIOC
    {
        public static IServiceCollection AddConfigurationServices(this IServiceCollection service, IConfiguration configuration)
        {
            #region Registra IOC

            #region IOC Application

            service.AddScoped<IApplicationServiceEquipamento, ApplicationServiceEquipamento>();
            service.AddScoped<IApplicationServiceFabricante, ApplicationServiceFabricante>();
            service.AddScoped<IApplicationServiceSituacao, ApplicationServiceSituacao>();
            service.AddScoped<IApplicationServiceTipoEquipamento, ApplicationServiceTipoEquipamento>();
            service.AddScoped<IApplicationServiceLaboratorio, ApplicationServiceLaboratorio>();

            #endregion IOC Application

            #region IOC Services

            service.AddScoped<IServiceEquipamento, ServiceEquipamento>();
            service.AddScoped<IServiceFabricante, ServiceFabricante>();
            service.AddScoped<IServiceSituacao, ServiceSituacao>();
            service.AddScoped<IServiceTipoEquipamento, ServiceTipoEquipamento>();
            service.AddScoped<IServiceLaboratorio, ServiceLaboratorio>();

            #endregion IOC Services

            #region Entity Framework

            service.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("AppDBConnection")));

            #endregion Entity Framework

            #region Repository SQL

            service.AddSingleton<SqlFactory>();
            service.AddScoped<IRepositoryEquipamento, RepositoryEquipamento>();
            service.AddScoped<IRepositoryFabricante, RepositoryFabricante>();
            service.AddScoped<IRepositorySituacao, RepositorySituacao>();
            service.AddScoped<IRepositoryTipoEquipamento, RepositoryTipoEquipamento>();
            service.AddScoped<IRepositoryLaboratorio, RepositoryLaboratorio>();

            #endregion Repository SQL

            #region IOC Mapper

            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MapperEquipamento());
                mc.AddProfile(new MapperFabricante());
                mc.AddProfile(new MapperLaboratorio());
                mc.AddProfile(new MapperSituacao());
                mc.AddProfile(new MapperTipoEquipamento());
            });
            var mapper = mappingConfig.CreateMapper();
            service.AddSingleton(mapper);

            #endregion IOC Mapper

            #endregion Registra IOC

            return service;
        }
    }
}