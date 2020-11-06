using Business.Interfaces;
using Data.Context;
using Data.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<MeuDbContext>();
            services.AddScoped<IGravidadeRepository, GravidadeRepository>();
            services.AddScoped<IStatusRepository, StatusRepository>();
            services.AddScoped<IAtendimentoRepository, AtendimentoRepository>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            
            services.AddTransient<IConfigureOptions<SwaggerGenOptions>, ConfigureSwaggerOptions>();

            return services;
        }
    }
}
