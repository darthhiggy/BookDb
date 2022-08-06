using BookDb.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookDb.Data.Configurations;

public class BookCreatorConfiguration : IEntityTypeConfiguration<BookCreatorModel>
{

    public void Configure(EntityTypeBuilder<BookCreatorModel> builder)
    {
        builder.ToTable("BookCreators", "Book");
    }
}
