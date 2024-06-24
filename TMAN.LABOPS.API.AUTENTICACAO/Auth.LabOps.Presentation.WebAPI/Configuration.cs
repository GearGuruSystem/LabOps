using Auth.LabOps.Infra.CrossCutting.IOC;
using Serilog;
using Serilog.Events;

namespace LabOps.WebApi
{
    public static class Configuration
    {
        public static IServiceCollection AddConfigurationCorsPolicy(this IServiceCollection services)
        {
            services.AddCors(opt =>
            {
                opt.AddPolicy(WebApiConfiguration.CorsPolicyName,
                    buld => buld
                    .WithOrigins(WebApiConfiguration.FrontEnd, WebApiConfiguration.AuthApi, WebApiConfiguration.ServiceNotification)
                    .AllowAnyHeader()
                    .WithMethods("GET", "POST", "PUT", "DELETE"));
            });
            return services;
        }

        public static ILoggingBuilder AddConfigurationLogger(this ILoggingBuilder builder)
        {
            var logger = new LoggerConfiguration()
                .MinimumLevel.Information()
                .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
                .Enrich.FromLogContext()
                .WriteTo.File("C:/ProjetosDev/LogLabOpsDev/logs/Auth/log-.log",
                    rollingInterval: RollingInterval.Day,
                    fileSizeLimitBytes: 5_000_000,
                    rollOnFileSizeLimit: true,
                    retainedFileCountLimit: 5,
                    outputTemplate: "{Timestamp:dd/MM/yyyy HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}")
                .Filter.ByExcluding(logEvent =>
                logEvent.Properties.TryGetValue("RequestPath", out var path) && path.ToString().Contains("/swagger"))
                .CreateLogger();

            Log.Information("Iniciado o WebApi");
            builder.AddSerilog(logger);

            return builder;
        }
    }
}
