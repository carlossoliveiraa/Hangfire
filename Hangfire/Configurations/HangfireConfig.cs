using Hangfire.Filters;
using Hangfire.SqlServer;

namespace Hangfire.Configurations
{
    public static class HangfireConfig
    {
        public static IServiceCollection AddHangfireConfig(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddHangfire(config => config
            .SetDataCompatibilityLevel(CompatibilityLevel.Version_170)
            .UseSimpleAssemblyNameTypeSerializer()
            .UseRecommendedSerializerSettings()
            .UseSqlServerStorage(configuration.GetConnectionString("HangfireConnection"),
                new SqlServerStorageOptions
                {
                    CommandBatchMaxTimeout = TimeSpan.FromMinutes(5),
                    SlidingInvisibilityTimeout = TimeSpan.FromMinutes(5),
                    QueuePollInterval = TimeSpan.Zero,
                    UseRecommendedIsolationLevel = true,
                    DisableGlobalLocks = true
                }));

            services.AddHangfireServer();

            return services;
        }

        public static IApplicationBuilder UseHangfire(this IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.EnvironmentName != "PRD")
            {
                app.UseHangfireDashboard(options: new DashboardOptions
                {
                    Authorization = new[] { new HangfireAuthorizationFilter() }
                });
            }

            return app;
        }
    }
}
