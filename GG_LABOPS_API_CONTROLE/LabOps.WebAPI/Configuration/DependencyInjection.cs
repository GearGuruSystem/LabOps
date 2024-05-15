using Autofac;
using LabOps.Infrastructure.CrossCutting.IOC;

namespace LabOps.WebAPI.Configuration
{
    public static class DependencyInjection
    {
        public static void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterModule(new ModuleIOC());
        }
    }
}
