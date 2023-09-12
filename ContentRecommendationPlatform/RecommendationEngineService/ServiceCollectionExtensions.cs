using RecommendationEngineService.Data;
using RecommendationEngineService.Services;

namespace RecommendationEngineService;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection RegisterServices(this IServiceCollection services)
    {
        

        services.AddScoped<IRecommendationService, RecommendationService>();
        services.AddScoped<IDataRepository, SqlDataRepository>();

        return services;
    }
}