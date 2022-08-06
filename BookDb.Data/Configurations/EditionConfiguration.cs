using BookDb.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookDb.Data.Configurations;

public class EditionConfiguration : IEntityTypeConfiguration<EditionModel>
{

    public void Configure(EntityTypeBuilder<EditionModel> builder)
    {
        builder.ToTable("Editions", "Book");
    }
}
