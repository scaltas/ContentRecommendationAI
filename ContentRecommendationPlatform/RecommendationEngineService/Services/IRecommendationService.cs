using RecommendationEngineService.Models;

namespace RecommendationEngineService.Services;

public interface IRecommendationService
{
    List<Recommendation> GetRecommendations(string userId);
}