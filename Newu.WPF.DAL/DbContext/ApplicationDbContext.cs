using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Function> Functions { get; set; }
    public DbSet<Organization> Organizations { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
    { 
        optionsBuilder.UseSqlServer("Server=localhost;Database=Newu.WPF;User Id=sa;Password=newu;"); 
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // 配置 User 和 Role 的一对多关系
        modelBuilder.Entity<User>()
            .HasMany(u => u.Roles)
            .WithOne()
            .HasForeignKey("User_ID");

        // 配置 Role 和 Function 的多对多关系
        modelBuilder.Entity<Role>()
            .HasMany(r => r.Functions)
            .WithMany(f => f.Roles)
            .UsingEntity<Dictionary<string, object>>(
                "RoleFunction",
                j => j.HasOne<Function>().WithMany().HasForeignKey("Function_ID"),
                j => j.HasOne<Role>().WithMany().HasForeignKey("Role_ID")
            );
    }
}
