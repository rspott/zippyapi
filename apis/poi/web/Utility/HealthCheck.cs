using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.Threading;
using System.Threading.Tasks;

namespace poi.Utility
{
    public class HealthCheck : IHealthCheck
    {
        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            var healthCheckResultHealthy = false; //TODO: implement a proper health check

            if (healthCheckResultHealthy)
                return Task.FromResult(HealthCheckResult.Healthy("POI is FOO."));

            return Task.FromResult(HealthCheckResult.Unhealthy("POI is UNHEALTHY!!!"));
        }
    }
}
