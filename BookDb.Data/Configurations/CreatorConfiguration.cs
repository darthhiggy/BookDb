using BookDb.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookDb.Data.Configurations;

public class CreatorConfiguration : IEntityTypeConfiguration<CreatorModel>
{

    public void Configure(EntityTypeBuilder<CreatorModel> builder)
    {
        builder.ToTable("Creators", "Book");
    }
}
