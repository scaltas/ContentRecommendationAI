using Microsoft.AspNetCore.Mvc;
using RecommendationEngineService.Models;
using RecommendationEngineService.Services;

namespace RecommendationEngineService.Controllers;

[Route("api/recommendations")]
[ApiController]
public class RecommendationController : ControllerBase
{
    // Your recommendation service
    private readonly IRecommendationService _recommendationService;

    public RecommendationController(IRecommendationService recommendationService)
    {
        _recommendationService = recommendationService;
    }

    [HttpGet("{userId}")]
    public ActionResult<IEnumerable<Recommendation>> GetRecommendations(string userId)
    {
        // Retrieve recommendations for the specified user
        var recommendations = _recommendationService.GetRecommendations(userId);

        if (recommendations == null || !recommendations.Any())
        {
            return NotFound("No recommendations found for the user.");
        }

        return Ok(recommendations);
    }
}