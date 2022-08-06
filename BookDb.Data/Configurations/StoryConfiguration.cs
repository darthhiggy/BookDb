using BookDb.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookDb.Data.Configurations;

public class StoryConfiguration : IEntityTypeConfiguration<StoryModel>
{

    public void Configure(EntityTypeBuilder<StoryModel> builder)
    {
        builder.ToTable("Stories", "Book");

        builder.HasMany(s => s.Creators)
            .WithOne(c => c.StoryModel);
    }
}
