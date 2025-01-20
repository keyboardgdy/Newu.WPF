public static class DataSeed
{
    public static void Seed(ApplicationDbContext context)
    {
        if (!context.Users.Any())
        {
            context.Users.AddRange(
                new User { Name = "Admin", Account = "admin", Password = "admin", Telephone = "1234567890", Email = "admin@example.com", Status = "Active", Organization_ID = 1, Remark = "Administrator", Profile = "admin.png", Create_By = "System", Create_Time = DateTime.Now, Update_By = "System", Update_Time = DateTime.Now }
            );
            context.SaveChanges();
        }

        if (!context.Roles.Any())
        {
            context.Roles.AddRange(
                new Role { Name = "Admin", Description = "Administrator role", Remark = "Full access", Create_By = "System", Create_Time = DateTime.Now, Update_By = "System", Update_Time = DateTime.Now }
            );
            context.SaveChanges();
        }

        if (!context.Functions.Any())
        {
            context.Functions.AddRange(
                new Function { Name = "Dashboard", Code = "dashboard", Icon = "dashboard.png", Parent_ID = 0, Remark = "Main dashboard", Create_By = "System", Create_Time = DateTime.Now, Update_By = "System", Update_Time = DateTime.Now }
            );
            context.SaveChanges();
        }

        if (!context.Organizations.Any())
        {
            context.Organizations.AddRange(
                new Organization { Name = "Head Office", Leader = "John Doe", Telephone = "1234567890", Parent_ID = 0, Remark = "Main office", Create_By = "System", Create_Time = DateTime.Now, Update_By = "System", Update_Time = DateTime.Now }
            );
            context.SaveChanges();
        }
    }
}
