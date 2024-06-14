using LabOps.Application.Interfaces;
using LabOps.Application.Service;
using LabOps.Domain.Core.Interfaces;
using LabOps.Domain.Core.Services;
using LabOps.Domain.Services.Services;
using LabOps.Infra.Data.DataAcess;
using LabOps.Infra.Data.DataContext;
using LabOps.Infra.Repository.Repository;
using LabOps.Infrastructure.CrossCutting.Adapter.Interfaces;
using LabOps.Infrastructure.CrossCutting.Adapter.Map;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LabOps.Infrastructure.CrossCutting.IOC
{
    public static class ConfigurationIOC
    {
        public static IServiceCollection DependencyInjected(this IServiceCollection service, IConfiguration configuration)
        {
            #region Registra IOC

            #region IOC Application
            service.AddScoped<IApplicationServiceEquipamento, ApplicationServiceEquipamento>();
            service.AddScoped<IApplicationServiceFabricante, ApplicationServiceFabricante>();
            service.AddScoped<IApplicationServiceSituacao, ApplicationServiceSituacao>();
            service.AddScoped<IApplicationServiceTipoEquipamento, ApplicationServiceTipoEquipamento>();
            service.AddScoped<IApplicationServiceLaboratorio, ApplicationServiceLaboratorio>();
            #endregion

            #region IOC Services 
            service.AddScoped<IServiceEquipamento, ServiceEquipamento>();
            service.AddScoped<IServiceFabricante, ServiceFabricante>();
            service.AddScoped<IServiceSituacao, ServiceSituacao>();
            service.AddScoped<IServiceTipoEquipamento, ServiceTipoEquipamento>();
            service.AddScoped<IServiceLaboratorio, ServiceLaboratorio>();
            #endregion

            #region Repository SQL
            service.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("AppDBConnection")));

            service.AddSingleton<SqlFactory>();
            service.AddScoped<IRepositoryEquipamento, RepositoryEquipamento>();
            service.AddScoped<IRepositoryFabricante, RepositoryFabricante>();
            service.AddScoped<IRepositorySituacao, RepositorySituacao>();
            service.AddScoped<IRepositoryTipoEquipamento, RepositoryTipoEquipamento>();
            service.AddScoped<IRepositoryLaboratorio, RepositoryLaboratorio>();
            #endregion

            #region IOC Mapper
            service.AddScoped<IMapperEquipamento, MapperEquipamento>();
            service.AddScoped<IMapperFabricante, MapperFabricante>();
            service.AddScoped<IMapperSituacao, MapperSituacao>();
            service.AddScoped<IMapperTipoEquipamento, MapperTipoEquipamento>();
            service.AddScoped<IMapperLaboratorio, MapperLaboratorio>();
            #endregion

            #endregion
            return service;
        }

    }
}
