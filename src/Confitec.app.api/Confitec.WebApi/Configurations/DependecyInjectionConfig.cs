using Confitec.Business.Interfaces;
using Confitec.Business.Services;
using Confitec.Data.Context;
using Confitec.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Confitec.WebApi.Configurations
{
    public static class DependecyInjectionConfig
    {
        public static IServiceCollection ResolveDependecies(this IServiceCollection services)
        {
            #region Context
            services.AddScoped<ApplicationDbContext>();
            #endregion

            #region Repository
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            #endregion

            #region Service
            services.AddScoped<IUsuarioService, UsuarioService>();
            #endregion

            #region Swagger
            //services.AddTransient<IConfigureOptions<SwaggerGenOptions>, ConfigureSwaggerOptions>();
            #endregion

            return services;
        }
    }
}
