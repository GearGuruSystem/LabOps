using Autofac;

namespace LabOps.Infrastructure.CrossCutting.IOC
{
    public class ModuleIOC : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            #region Carrega IOC

            ConfigurationIOC_old.Load(builder);

            #endregion
        }
    }
}
