using BookDb.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookDb.Data.Configurations;

public class CreatorTypeConfiguration : IEntityTypeConfiguration<CreatorTypeModel>
{

    public void Configure(EntityTypeBuilder<CreatorTypeModel> builder)
    {
        builder.ToTable("CreatorTypes", "Book");
    }
}
