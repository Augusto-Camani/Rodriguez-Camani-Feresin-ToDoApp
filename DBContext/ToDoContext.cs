using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;

namespace TAREALABO;

public class ToDoContext : DbContext
{
    public ToDoContext(DbContextOptions<ToDoContext> options) : base(options)
    {
    }
    public DbSet<User> Users { get; set; }
    public DbSet<ToDoItem> ToDoItems { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("Users");
                entity.HasKey(e => e.UserId);
                entity.HasMany(t => t.toDoItems)
                    .WithOne(u => u.User)
                    .HasForeignKey(u => u.UserId);
            });
        modelBuilder.Entity<ToDoItem>(entity =>
            {
                entity.ToTable("ToDoItems");
                entity.HasKey(e => e.ToDoId);
                entity.HasOne(u => u.User);
            }
        );

        base.OnModelCreating(modelBuilder);
    }
}
