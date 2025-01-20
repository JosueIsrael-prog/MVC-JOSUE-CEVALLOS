using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Country> Countries { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Filename=MyCountriesDb.db");
    }
}
