using Lesson4EntityFrameworkCoreIntro.Models;
using Microsoft.EntityFrameworkCore;

namespace Lesson4EntityFrameworkCoreIntro.Data;

internal class LibraryDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=STHQ0118-01;Initial Catalog=Library;User ID=admin;Password=admin;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
    }

    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
}
