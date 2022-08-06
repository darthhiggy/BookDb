using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using BookDb.Data.Configurations;
using BookDb.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BookDb.Data;

public class BooksDbContext : DbContext
{
    public BooksDbContext(DbContextOptions<BooksDbContext> contextOptions)
    : base(contextOptions)
    {
        
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.EnableSensitiveDataLogging(true);
    }
    
    public DbSet<BookCreatorModel> BookCreators { get; set; }
    public DbSet<CreatorModel> Creators { get; set; }
    public DbSet<CreatorTypeModel> CreatorTypes { get; set; }
    public DbSet<EditionModel> Editions { get; set; }
    public DbSet<GenreModel> Genres { get; set; }
    public DbSet<PublisherModel> Publishers { get; set; }
    public DbSet<StoryModel> Stories { get; set; }
    public DbSet<PersonNameModel> PeopleIdentities { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof(BooksDbContext)) ?? Assembly.GetExecutingAssembly());
        
    }
}
