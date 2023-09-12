using RecommendationEngineService.Data;
using RecommendationEngineService.Models;

namespace RecommendationEngineService.Services;

public class RecommendationService : IRecommendationService
{
    private readonly IDataRepository _dataRepository;

    public RecommendationService(IDataRepository dataRepository)
    {
        _dataRepository = dataRepository;
    }

    public List<Recommendation> GetRecommendations(string userId)
    {
        var userInteractions = _dataRepository.GetUserInteractions(userId);
        var allContentMetadata = _dataRepository.GetAllContentMetadata();
        var ratedInteractions = GetRatedInteractions(userInteractions);

        // Calculate average ratings for each genre
        var genreAverages = CalculateGenreAverages(ratedInteractions, allContentMetadata);

        // Sort genres by average rating in descending order
        var sortedGenres = genreAverages.OrderByDescending(kv => kv.Value);

        // Initialize a list to store recommendations
        var recommendations = new List<Recommendation>();

        foreach (var userGenreRating in sortedGenres)
        {
            // Fetch content for the current genre
            var genreContent = allContentMetadata.Where(content => content.Genre == userGenreRating.Key).ToList();

            // Filter and prioritize content from this genre
            var genreRecommendations = GenerateGenreBasedRecommendations(userGenreRating.Value, genreContent);

            recommendations.AddRange(genreRecommendations);
        }

        // Take the top N recommendations
        var topRecommendations = recommendations
            .Where(r => ratedInteractions
                .All(i => i.Content.Id != r.ContentId))
            .Take(10)
            .ToList();

        return topRecommendations;
    }

    private List<Interaction> GetRatedInteractions(List<Interaction> userInteractions)
    {
        return userInteractions
            .Where(interaction => interaction.InteractionType == InteractionType.Rating)
            .ToList();
    }

    private Dictionary<string, double> CalculateGenreAverages(List<Interaction> ratedInteractions, List<Content> allContentMetadata)
    {
        var genreAverages = new Dictionary<string, double>();

        foreach (var genre in allContentMetadata.Select(content => content.Genre).Distinct())
        {
            var genreInteractions = ratedInteractions.Where(interaction => interaction.Content.Genre == genre).ToList();

            if (genreInteractions.Any())
            {
                var averageRating = genreInteractions.Average(interaction => interaction.Rating ?? 0);
                genreAverages[genre] = averageRating;
            }
            else
            {
                genreAverages[genre] = 0; // Default to 0 if no interactions in this genre
            }
        }

        return genreAverages;
    }

    private List<Recommendation> GenerateGenreBasedRecommendations(double userGenreRating, List<Content> genreContent)
    {
        var recommendations = new List<Recommendation>();

        foreach (var content in genreContent)
        {
            var recommendation = new Recommendation
            {
                ContentId = content.Id,
                Title = content.Title,
                Genre = content.Genre,
                Score = userGenreRating * content.AverageRating
            };

            recommendations.Add(recommendation);
        }

        // Sort recommendations by score in descending order
        recommendations = recommendations.OrderByDescending(rec => rec.Score).ToList();

        return recommendations;
    }
}