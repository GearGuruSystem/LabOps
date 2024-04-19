using AutoMapper;
using Dapper;
using GG_LabOps_Application.Mapping;
using GG_LabOps_Application.Profiles;
using GG_LabOps_Application.Services;
using GG_LabOps_Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace GG_LabOps_Application.ApplicationModule
{
    public static class ApplicationModule
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddApplicationService();
            services.MapperService();
            AddDapperMappingCustom();
            return services;
        }

        private static IServiceCollection AddApplicationService(this IServiceCollection services)
        {
            services.AddScoped<ILaboratoryServices, LaboratoryServices>();
            services.AddScoped<IEquipamentService, EquipamentServices>();
            return services;
        }

        private static void AddDapperMappingCustom()
        {
            SqlMapper.AddTypeHandler(new EquipamentMap());

        }

        private static IServiceCollection MapperService(this IServiceCollection services)
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new EquipamentProfile());
            });

            var mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
            return services;
        }
    }
}
