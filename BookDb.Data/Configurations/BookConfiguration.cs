using BookDb.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookDb.Data.Configurations;

public class BookConfiguration : IEntityTypeConfiguration<BookModel>
{

    public void Configure(EntityTypeBuilder<BookModel> builder)
    {
        builder.ToTable("Books", "Book");

        builder.HasMany(b => b.Stories)
            .WithMany(s => s.Books)
            .UsingEntity(j => j.ToTable("BookStories"));

        builder.HasMany(b => b.Editions)
            .WithMany(e => e.Books)
            .UsingEntity(j => j.ToTable("BookEditions"));
    }
}
