using Microsoft.EntityFrameworkCore;
using RecommendationEngineService.Models;

namespace RecommendationEngineService.Data;

public class SqlDataRepository : IDataRepository
{
    private readonly RecommendationDbContext _dbContext;

    public SqlDataRepository(RecommendationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public List<Interaction> GetUserInteractions(string userId)
    {
        return _dbContext.Interactions
            .Where(interaction => interaction.UserID == userId)
            .Include(interaction => interaction.Content)
            .ToList();
    }

    public List<Content> GetAllContentMetadata()
    {
        return _dbContext.Content.ToList();
    }
}