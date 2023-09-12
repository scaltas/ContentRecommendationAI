using Microsoft.EntityFrameworkCore;
using RecommendationEngineService.Models;

namespace RecommendationEngineService.Data;

public class RecommendationDbContext : DbContext
{
    public RecommendationDbContext(DbContextOptions<RecommendationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Content> Content { get; set; }
    public DbSet<Interaction> Interactions { get; set; }
}

