using GG_labOps_Domain.Interfaces;
using GG_LabOps_Services.Services;
using Microsoft.Extensions.DependencyInjection;

namespace GG_LabOps_Services.ApplicationModule
{
    public static class ApplicationModule
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddApplicationService();
            services.AddHttpServices();
            services.AddSessionService();
            services.AddAutoMapperService();

            return services;
        }

        private static IServiceCollection AddApplicationService(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            return services;
        }

        private static IServiceCollection AddHttpServices(this IServiceCollection services)
        {
            //services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            return services;
        }

        private static IServiceCollection AddSessionService(this IServiceCollection services)
        {
            //services.AddScoped<ISessaoHelper, SessaoHelper>();
            //services.AddSession(o =>
            //{
            //    o.Cookie.HttpOnly = true;
            //    o.Cookie.IsEssential = true;
            //});

            return services;
        }

        private static IServiceCollection AddAutoMapperService(this IServiceCollection services)
        {
            return services;
        }
    }
}