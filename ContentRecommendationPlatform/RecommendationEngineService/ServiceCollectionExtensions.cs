using RecommendationEngineService.Services;

namespace RecommendationEngineService
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IRecommendationService, RecommendationService>();

            return services;
        }
    }
}
