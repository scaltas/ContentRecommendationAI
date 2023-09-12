namespace RecommendationEngineService.Models;

public class Content
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Genre { get; set; }
    public DateTime ReleaseDate { get; set; }
    public string Author { get; set; }
    public double AverageRating { get; set; } 
}