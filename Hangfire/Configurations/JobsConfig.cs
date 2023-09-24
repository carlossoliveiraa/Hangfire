using Hangfire.Application.Interfaces.Service;

namespace Hangfire.Configurations
{
    public static class JobsConfig
    {
        public static IApplicationBuilder UseJobsConfig(this IApplicationBuilder app, IServiceProvider serviceProvider)
        {
            var configuration = app.ApplicationServices.GetService<IConfiguration>();
            var hangfireJobs = configuration.GetSection("HangfireJobs").GetChildren();

            foreach (var job in hangfireJobs)
            {
                var jobName = job.Key;
                var cronExpression = job["CronExpression"];
                var enabled = bool.Parse(job["Enabled"]);

                if (enabled)
                {
                    switch (jobName)
                    {
                        case "PrimeiroJob":
                            RecurringJob.AddOrUpdate<IPrimeiroJobService>("Executa.PrimeiroJob", x => x.ExecuteJobAsync(), cronExpression);
                            break;
                        case "SegundoJob":
                            RecurringJob.AddOrUpdate<ISegundoJobService>("Executa.SegundoJob", x => x.ExecuteJobAsync(), cronExpression);
                            break;
                        case "TerceiroJob":
                            RecurringJob.AddOrUpdate<ITerceiroJobService>("Executa.TerceiroJob", x => x.ExecuteJobAsync(), cronExpression);
                            break;
                        case "QuartoJob":
                            RecurringJob.AddOrUpdate<IQuartoJobService>("Executa.QuartoJob", x => x.ExecuteJobAsync(), cronExpression);
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    RecurringJob.RemoveIfExists(jobName.Replace(" ", "."));
                }
            }

            return app;
        }
    }
}
