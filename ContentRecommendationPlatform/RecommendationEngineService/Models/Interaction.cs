namespace RecommendationEngineService.Models;

public class Interaction
{
    public string UserID { get; set; }
    public Content Content { get; set; }
    public InteractionType InteractionType { get; set; }
    public DateTime Timestamp { get; set; }
    public int? Rating { get; set; }
}

public enum InteractionType
{
    Click,
    View,
    Purchase,
    Rating,
    Search
}