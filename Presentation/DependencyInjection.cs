using Microsoft.Extensions.DependencyInjection;

namespace Presentation;

public static class DependencyInjection
{
    /// <summary>
    /// Add dependencies from Presentation Layer
    /// </summary>
    /// <param name="services">Services collection</param>
    /// <returns></returns>
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        return services;
    }
}