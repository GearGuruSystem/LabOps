using Auth.LabOps.Application.Interfaces;
using Auth.LabOps.Application.Services;
using Auth.LabOps.Domain.Core.Interfaces;
using Auth.LabOps.Domain.Core.Services;
using Auth.LabOps.Domain.Services.Interfaces;
using Auth.LabOps.Domain.Services.Security;
using Auth.LabOps.Domain.Services.Services;
using Auth.LabOps.Infrastructure.CrossCutting.Adapter.Interfaces;
using Auth.LabOps.Infrastructure.CrossCutting.Adapter.Map;
using Auth.LabOps.Infrastructure.Data.DataAcess;
using Auth.LabOps.Infrastructure.Repository.Repository;
using Autofac;

namespace Auth.LabOps.Infrastructure.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region registra IOC

            #region IOC Application
            builder.RegisterType<ApplicationServiceUsuario>().As<IApplicationServiceUsuario>();
            #endregion

            #region IOC Services 
            builder.RegisterType<ServiceUsuario>().As<IServiceUsuario>();
                #region Security Jwt
                builder.RegisterType<ServiceToken>().As<IServiceToken>();
                #endregion
            #endregion

            #region Repository SQL
            builder.RegisterType<RepositoryUsuario>().As<IRepositoryUsuario>();
            builder.RegisterType<SqlData>().As<ISqlData>();
            builder.RegisterType<SqlFactory>().AsSelf().InstancePerLifetimeScope();
            #endregion

            #region IOC Mapper
            builder.RegisterType<MapperUsuario>().As<IMapperUsuario>();
            #endregion

            #endregion
        }
    }
}
