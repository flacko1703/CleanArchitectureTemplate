using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class DependencyInjection
{
    /// <summary>
    /// Add dependencies from Infrastructure Layer
    /// </summary>
    /// <param name="services">Services collection</param>
    /// <returns></returns>
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        return services;
    }
}