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
            #endregion

            #region IOC Services 
            builder.RegisterType<ServiceEquipamento>().As<IServiceEquipamento>();
            builder.RegisterType<ServiceFabricante>().As<IServiceFabricante>();
            builder.RegisterType<ServiceSituacao>().As<IServiceSituacao>();
            #endregion

            #region Repository SQL
            builder.RegisterType<RepositoryEquipamento>().As<IRepositoryEquipamento>();
            builder.RegisterType<RepositoryFabricante>().As<IRepositoryFabricante>();
            builder.RegisterType<RepositorySituacao>().As<IRepositorySituacao>();
            #endregion

            #region IOC Mapper
            builder.RegisterType<MapperEquipamento>().As<IMapperEquipamento>();
            builder.RegisterType<MapperFabricante>().As<IMapperFabricante>();
            builder.RegisterType<MapperSituacao>().As<IMapperSituacao>();
            #endregion

            #endregion
        }
    }
}
