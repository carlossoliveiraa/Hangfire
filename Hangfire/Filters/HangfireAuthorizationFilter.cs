using Hangfire.Dashboard;
using System.Diagnostics.CodeAnalysis;

namespace Hangfire.Filters
{
    public class HangfireAuthorizationFilter : IDashboardAuthorizationFilter
    {
        public bool Authorize([NotNull] DashboardContext context)
        {
            var httpContext = context.GetHttpContext();

            return true;
        }
    }
}
