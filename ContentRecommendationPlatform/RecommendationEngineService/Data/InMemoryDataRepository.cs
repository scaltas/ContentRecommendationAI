using RecommendationEngineService.Models;

namespace RecommendationEngineService.Data;

public class InMemoryDataRepository : IDataRepository
{
    private readonly List<Interaction> _userInteractions = new();
    private readonly List<Content> _contentMetadata = new();

    public InMemoryDataRepository()
    {
        // Initialize some sample data
        InitializeSampleData();
    }

    public List<Interaction> GetUserInteractions(string userId)
    {
        return _userInteractions.Where(interaction => interaction.UserID == userId).ToList();
    }

    public List<Content> GetAllContentMetadata()
    {
        return _contentMetadata.ToList();
    }

    private void InitializeSampleData()
    {
        // Sample content metadata
        _contentMetadata.Add(new Content
        {
            ContentID = "content1",
            Title = "Movie 1",
            Description = "Description for Movie 1",
            Genre = "Drama",
            ReleaseDate = DateTime.Parse("2022-01-15"),
            Author = "Director A",
            AverageRating = 4.5 // Average rating for the content
        });

        _contentMetadata.Add(new Content
        {
            ContentID = "content2",
            Title = "Movie 2",
            Description = "Description for Movie 2",
            Genre = "Action",
            ReleaseDate = DateTime.Parse("2021-11-20"),
            Author = "Director B",
            AverageRating = 3.8 // Average rating for the content
        });

        _contentMetadata.Add(new Content
        {
            ContentID = "content3",
            Title = "Movie 3",
            Description = "Description for Movie 3",
            Genre = "Drama",
            ReleaseDate = DateTime.Parse("2019-01-15"),
            Author = "Director A",
            AverageRating = 2.1 // Average rating for the content
        });

        _contentMetadata.Add(new Content
        {
            ContentID = "content4",
            Title = "Movie 4",
            Description = "Description for Movie 4",
            Genre = "Action",
            ReleaseDate = DateTime.Parse("2023-11-20"),
            Author = "Director D",
            AverageRating = 4.7 // Average rating for the content
        });

        // Sample user interactions
        _userInteractions.Add(new Interaction
        {
            UserID = "user1",
            Content = _contentMetadata.First(c => c.ContentID == "content1"),
            InteractionType = InteractionType.Rating,
            Timestamp = DateTime.UtcNow,
            Rating = 4
        });

        _userInteractions.Add(new Interaction
        {
            UserID = "user1",
            Content = _contentMetadata.First(c => c.ContentID == "content2"),
            InteractionType = InteractionType.Rating,
            Timestamp = DateTime.UtcNow,
            Rating = 5
        });


    }
}