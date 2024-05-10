using System.Runtime.CompilerServices;

namespace GG_LabOps_WebApi.Configuration
{
    public static class ApplicationConfig
    {
        public static IApplicationBuilder AddConfigurationBuilderApp(this IApplicationBuilder builder)
        {
            builder.UseAuthentication();
            builder.UseAuthorization();
            return builder;
        }
    }
}
