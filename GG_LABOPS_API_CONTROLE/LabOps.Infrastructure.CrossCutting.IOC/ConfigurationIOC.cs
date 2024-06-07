using Autofac;
using LabOps.Application.Interfaces;
using LabOps.Application.Service;
using LabOps.Domain.Core.Interfaces;
using LabOps.Domain.Core.Services;
using LabOps.Domain.Services.Services;
using LabOps.Infrastructure.CrossCutting.Adapter.Interfaces;
using LabOps.Infrastructure.CrossCutting.Adapter.Map;
using LabOps.Infrastructure.Data.DataAcess;
using LabOps.Infrastructure.Data.DataContext;
using LabOps.Infrastructure.Repository.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LabOps.Infrastructure.CrossCutting.IOC
{
    public class ConfigurationIOC_old
    {
        public static void Load(ContainerBuilder builder)
        {
            #region registra IOC

            #region IOC Application
            builder.RegisterType<ApplicationServiceEquipamento>().As<IApplicationServiceEquipamento>();
            builder.RegisterType<ApplicationServiceFabricante>().As<IApplicationServiceFabricante>();
            builder.RegisterType<ApplicationServiceSituacao>().As<IApplicationServiceSituacao>();
            builder.RegisterType<ApplicationServiceTipoEquipamento>().As<IApplicationServiceTipoEquipamento>();
            builder.RegisterType<ApplicationServiceLaboratorio>().As<IApplicationServiceLaboratorio>();
            #endregion

            #region IOC Services 
            builder.RegisterType<ServiceEquipamento>().As<IServiceEquipamento>();
            builder.RegisterType<ServiceFabricante>().As<IServiceFabricante>();
            builder.RegisterType<ServiceSituacao>().As<IServiceSituacao>();
            builder.RegisterType<ServiceTipoEquipamento>().As<IServiceTipoEquipamento>();
            builder.RegisterType<ServiceLaboratorio>().As<IServiceLaboratorio>();
            #endregion

            #region Repository SQL
            builder.RegisterType<AppDbContext>();
            builder.RegisterType<RepositoryEquipamento>().As<IRepositoryEquipamento>();
            builder.RegisterType<RepositoryFabricante>().As<IRepositoryFabricante>();
            builder.RegisterType<RepositorySituacao>().As<IRepositorySituacao>();
            builder.RegisterType<RepositoryTipoEquipamento>().As<IRepositoryTipoEquipamento>();
            builder.RegisterType<RepositoryLaboratorio>().As<IRepositoryLaboratorio>();
            #endregion

            #region IOC Mapper
            builder.RegisterType<MapperEquipamento>().As<IMapperEquipamento>();
            builder.RegisterType<MapperFabricante>().As<IMapperFabricante>();
            builder.RegisterType<MapperSituacao>().As<IMapperSituacao>();
            builder.RegisterType<MapperTipoEquipamento>().As<IMapperTipoEquipamento>();
            builder.RegisterType<MapperLaboratorio>().As<IMapperLaboratorio>();
            #endregion

            #endregion
        }
    }

    public static class ConfigurationIOC
    {
        public static void DependencyInjected(this IServiceCollection service, IConfiguration configuration)
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
                options.UseSqlServer(configuration.GetConnectionString("DataBaseContext")));

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
        }
    }
}
