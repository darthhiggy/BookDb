using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace BookDb.Data;

public class BooksDbContextFactory : IDesignTimeDbContextFactory<BooksDbContext>
{

    public BooksDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<BooksDbContext>();
        optionsBuilder.UseSqlServer("Server = ./; Database = BooksDb; Trusted_Connection = False;");

        return new BooksDbContext(optionsBuilder.Options);
    }
}
