using Hangfire.Configurations;

namespace Hangfire
{
    public class Startup
    {
        public readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.ConfigureInternalServices(_configuration);

            services.AddHangfireConfig(_configuration);

            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IServiceProvider serviceProvider)
        {
            app.UseHttpsRedirection();

            app.UseRouting();

            if (env.EnvironmentName != "PRD")
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHangfire(env);

            app.UseJobsConfig(serviceProvider);

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
