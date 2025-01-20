public class OrganizationRepository : Repository<Organization>
{
    public OrganizationRepository(ApplicationDbContext context) : base(context)
    {
    }
}
