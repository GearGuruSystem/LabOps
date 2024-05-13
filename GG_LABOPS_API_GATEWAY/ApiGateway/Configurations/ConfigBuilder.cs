namespace OcelotApiGateway.Configurations
{
    public static class ConfigBuilder
    {
        public static IConfiguration ConfigureOcelotConfiguration(this WebApplication app)
        {
            var configurationBuilder = new ConfigurationBuilder()
            .SetBasePath(app.Environment.ContentRootPath)
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .AddJsonFile($"appsettings.{app.Environment.EnvironmentName}.json", optional: true, reloadOnChange: true)
            .AddJsonFile($"configuration.{app.Environment.EnvironmentName}.json")
            .AddEnvironmentVariables();
            return configurationBuilder.Build();
        }
    }
}
