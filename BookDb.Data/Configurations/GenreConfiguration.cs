using BookDb.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookDb.Data.Configurations;

public class GenreConfiguration : IEntityTypeConfiguration<GenreModel>
{

    public void Configure(EntityTypeBuilder<GenreModel> builder)
    {
        builder.ToTable("Genres", "Book");
    }
}
