public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _context;

    public UnitOfWork(ApplicationDbContext context)
    {
        _context = context;
        Users = new UserRepository(_context);
        Roles = new RoleRepository(_context);
        Functions = new FunctionRepository(_context);
        Organizations = new OrganizationRepository(_context);
    }

    public UserRepository Users { get; private set; }
    public RoleRepository Roles { get; private set; }
    public FunctionRepository Functions { get; private set; }
    public OrganizationRepository Organizations { get; private set; }

    public async Task<int> CompleteAsync()
    {
        return await _context.SaveChangesAsync();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}
