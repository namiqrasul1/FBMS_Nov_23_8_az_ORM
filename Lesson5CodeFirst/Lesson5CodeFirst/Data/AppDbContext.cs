using Lesson5CodeFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace Lesson5CodeFirst.Data;

public class AppDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=STHQ0118-01;Initial Catalog=CodeFirstTest;User ID=admin;Password=admin;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // one to one
        modelBuilder.Entity<User>().ToTable("Fazils");
        modelBuilder.Entity<User>()
            .HasKey(u => u.Id);
        modelBuilder.Entity<User>()
           .HasOne(u => u.Role)
           .WithOne(r => r.User)
           .HasForeignKey<Role>(r => r.Id)
           .OnDelete(DeleteBehavior.Cascade);

        // one to many
        modelBuilder.Entity<Product>()
                    .HasOne(p => p.Category)
                    .WithMany(c => c.Products)
                    .HasForeignKey(p => p.CategoryId)
                    .OnDelete(DeleteBehavior.SetNull);


        // one to many
        modelBuilder.Entity<AuthorBook>()
                    .HasKey(ab => new { ab.AuthorId, ab.BookId});

        modelBuilder.Entity<AuthorBook>()
                    .HasOne(ab => ab.Book)
                    .WithMany(b => b.Authors)
                    .HasForeignKey(ab => ab.BookId);

        modelBuilder.Entity<AuthorBook>()
                    .HasOne(ab => ab.Author)
                    .WithMany(b => b.Books)
                    .HasForeignKey(ab => ab.AuthorId);

    }
}
