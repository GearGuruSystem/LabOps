using Auth.LabOps.Application.Interfaces;
using Auth.LabOps.Application.Services;
using Auth.LabOps.Domain.Core.Interfaces;
using Auth.LabOps.Domain.Core.Services;
using Auth.LabOps.Domain.Services.Interfaces;
using Auth.LabOps.Domain.Services.Security;
using Auth.LabOps.Domain.Services.Services;
using Auth.LabOps.Infra.CrossCutting.Adapter.Interfaces;
using Auth.LabOps.Infra.CrossCutting.Adapter.Map;
using Auth.LabOps.Infrastructure.Data.DataAcess;
using Auth.LabOps.Infrastructure.Data.DataContex;
using Auth.LabOps.Infrastructure.Repository.Repository;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Auth.LabOps.Infra.CrossCutting.IOC
{
    public static class ConfigurationIOC
    {
        public static IServiceCollection DependencyInjected(this IServiceCollection services, IConfiguration configuration)
        {
            #region registra IOC

            #region IOC Application
            services.AddScoped<IApplicationServiceUsuario, ApplicationServiceUsuario>();
            #endregion

            #region IOC Services 
            services.AddScoped<IServiceUsuario, ServiceUsuario>();
            #region Security Jwt
            services.AddScoped<IServiceToken, ServiceToken>();
            #endregion
            #endregion

            #region Repository SQL
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("AppDataConnection")));
            services.AddScoped<IRepositoryUsuario, RepositoryUsuario>();
            services.AddScoped<ISqlData, SqlData>();
            services.AddScoped<SqlFactory>();
            #endregion

            #region IOC Mapper
            services.AddScoped<IMapperUsuario, MapperUsuario>();
            #endregion

            #endregion
            return services;
        }

        public static IServiceCollection AddJwtConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IServiceToken, ServiceToken>();

            #region Criação de JWT Token
            byte[] chave = Encoding.ASCII.GetBytes(configuration.GetSection("JWT:Secret").Value);

            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(chave),
                    ValidateIssuer = true,
                    ValidIssuer = configuration.GetSection("JWT:Issuer").Value,
                    ValidateAudience = true,
                    ValidAudience = configuration.GetSection("JWT:Audience").Value,
                    ValidateLifetime = true,
                };
            });
            #endregion
            return services;
        }

        public static IApplicationBuilder UseJwtConfiguration(this IApplicationBuilder app)
        {
            app.UseAuthentication();
            app.UseAuthorization();
            return app;
        }
    }
}