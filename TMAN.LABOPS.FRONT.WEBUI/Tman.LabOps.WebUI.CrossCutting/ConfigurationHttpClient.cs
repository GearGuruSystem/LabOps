using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Net.Http.Headers;
using Tman.LabOps.WebUI.Application;

namespace Tman.LabOps.WebUI.CrossCutting
{
    public static class ConfigurationHttpClient
    {
        public static IServiceCollection AddHttpClientConfiguration(this IServiceCollection services)
        {
            services.AddHttpClient(Configuration.ClientName, options =>
            {
                options.BaseAddress = new Uri(Configuration.BaseAdressApi);
                options.DefaultRequestHeaders.Add(HeaderNames.Accept, "Application/Json");
            });

            return services;
        }
    }
}