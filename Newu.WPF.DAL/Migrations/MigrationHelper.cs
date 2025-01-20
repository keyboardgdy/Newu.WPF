using Microsoft.EntityFrameworkCore;

public static class MigrationHelper
{
    public static void ApplyMigrations(ApplicationDbContext context)
    {
        context.Database.Migrate();
    }
}
