public class RoleRepository : Repository<Role>
{
    public RoleRepository(ApplicationDbContext context) : base(context)
    {
    }
}
