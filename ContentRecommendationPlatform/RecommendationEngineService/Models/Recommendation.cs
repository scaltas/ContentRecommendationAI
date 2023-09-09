namespace RecommendationEngineService.Models;

public class Recommendation
{
    public string ContentId { get; set; }
    public string Title { get; set; }
    public double Score { get; set; }
}