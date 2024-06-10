using Auth.LabOps.Infrastructure.CrossCutting.IOC;
using Autofac;

namespace Auth.LabOps.Presentation.WebAPI.Configuration
{
    public static class DependencyInjection
    {
        public static void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterModule(new ModuleIOC());
        }
    }
}
