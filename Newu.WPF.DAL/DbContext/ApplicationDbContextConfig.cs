using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class ApplicationDbContextConfig : IEntityTypeConfiguration<User>, IEntityTypeConfiguration<Role>, IEntityTypeConfiguration<Function>, IEntityTypeConfiguration<Organization>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(u => u.ID);
        builder.HasMany(u => u.Roles)
               .WithOne()
               .HasForeignKey("User_ID");
    }

    public void Configure(EntityTypeBuilder<Role> builder)
    {
        builder.HasKey(r => r.ID);
        builder.HasMany(r => r.Functions)
               .WithMany(f => f.Roles)
               .UsingEntity<Dictionary<string, object>>(
                   "RoleFunction",
                   j => j.HasOne<Function>().WithMany().HasForeignKey("Function_ID"),
                   j => j.HasOne<Role>().WithMany().HasForeignKey("Role_ID")
               );
    }

    public void Configure(EntityTypeBuilder<Function> builder)
    {
        builder.HasKey(f => f.ID);
    }

    public void Configure(EntityTypeBuilder<Organization> builder)
    {
        builder.HasKey(o => o.ID);
    }
}
