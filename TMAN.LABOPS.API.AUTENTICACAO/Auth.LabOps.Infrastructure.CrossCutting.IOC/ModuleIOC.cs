using Autofac;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;

namespace Auth.LabOps.Infrastructure.CrossCutting.IOC
{
    public class ModuleIOC : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            #region Carrega IOC

            ConfigurationIOC.Load(builder);

            #endregion
        }
    }
}
