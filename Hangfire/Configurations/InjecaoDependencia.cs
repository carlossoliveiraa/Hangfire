using Hangfire.Application.Interfaces.Repository;
using Hangfire.Application.Interfaces.Service;
using Hangfire.Application.Services;
using Hangfire.Data.Repository;

namespace Hangfire.Configurations
{
    public static class InjecaoDependencia
    {
        public static IServiceCollection ConfigureInternalServices(this IServiceCollection services, IConfiguration configuration)
        {
            return services.AddServices();              
        }

        private static IServiceCollection AddServices(this IServiceCollection services)
        {
            //Servicos
            services.AddScoped<IPrimeiroJobService, PrimeiroJobService>();
            services.AddScoped<ISegundoJobService, SegundoJobService>();
            services.AddScoped<ITerceiroJobService, TerceiroJobService>();
            services.AddScoped<IQuartoJobService, QuartoJobService>();

            //Repositorio
            services.AddScoped<IPrimeiroJobRepository, PrimeiroJobRepository>();
            services.AddScoped<ISegundoJobRepository, SegundoJobRepository>();
            services.AddScoped<ITerceiroJobRepository, TerceiroJobRepository>();
            services.AddScoped<IQuartoJobRepository, QuartoJobRepository>();
            return services;
        } 
    }
}
