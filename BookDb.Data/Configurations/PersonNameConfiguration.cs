using BookDb.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookDb.Data.Configurations;

public class PersonNameConfiguration : IEntityTypeConfiguration<PersonNameModel>
{

    public void Configure(EntityTypeBuilder<PersonNameModel> builder)
    {
        builder.ToTable("Name", "People");
    }
}
