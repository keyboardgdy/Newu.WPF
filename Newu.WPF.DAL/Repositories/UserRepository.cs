public class UserRepository : Repository<User>
{
    public UserRepository(ApplicationDbContext context) : base(context)
    {
    }
}
