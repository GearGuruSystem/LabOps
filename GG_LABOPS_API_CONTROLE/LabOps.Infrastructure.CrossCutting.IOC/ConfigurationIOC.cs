using Autofac;
using LabOps.Application.Interfaces;
using LabOps.Application.Service;
using LabOps.Domain.Core.Interfaces;
using LabOps.Domain.Core.Services;
using LabOps.Domain.Services.Services;
using LabOps.Infrastructure.CrossCutting.Adapter.Interfaces;
using LabOps.Infrastructure.CrossCutting.Adapter.Map;
using LabOps.Infrastructure.Repository.Repository;

namespace LabOps.Infrastructure.CrossCutting.IOC
{
    public class ConfigurationIOC
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
}
