using BookDb.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookDb.Data.Configurations;

public class PublisherConfiguration : IEntityTypeConfiguration<PublisherModel>
{

    public void Configure(EntityTypeBuilder<PublisherModel> builder)
    {
        builder.ToTable("Publishers", "Book");
    }
}
