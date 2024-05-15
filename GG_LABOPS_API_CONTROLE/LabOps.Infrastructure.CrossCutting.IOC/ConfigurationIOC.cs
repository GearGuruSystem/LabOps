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
            #endregion

            #region IOC Services 
            builder.RegisterType<ServiceEquipamento>().As<IServiceEquipamento>();
            #endregion

            #region Repository SQL
            builder.RegisterType<RepositoryEquipamento>().As<IRepositoryEquipamento>();
            #endregion

            #region IOC Mapper
            builder.RegisterType<MapperEquipamento>().As<IMapperEquipamento>();
            #endregion

            #endregion
        }
    }
}
