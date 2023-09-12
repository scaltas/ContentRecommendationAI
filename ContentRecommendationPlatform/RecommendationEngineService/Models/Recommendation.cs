namespace RecommendationEngineService.Models;

public class Recommendation
{
    public int ContentId { get; set; }
    public string Title { get; set; }
    public string Genre { get; set; }
    public double Score { get; set; }
}