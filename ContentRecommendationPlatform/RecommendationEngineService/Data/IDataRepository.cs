using RecommendationEngineService.Models;

namespace RecommendationEngineService.Data;

public interface IDataRepository
{
    // Retrieve user interactions for a specific user
    List<Interaction> GetUserInteractions(string userId);

    // Retrieve all content metadata
    List<Content> GetAllContentMetadata();
}