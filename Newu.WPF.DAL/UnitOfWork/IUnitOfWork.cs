public interface IUnitOfWork : IDisposable
{
    UserRepository Users { get; }
    RoleRepository Roles { get; }
    FunctionRepository Functions { get; }
    OrganizationRepository Organizations { get; }
    Task<int> CompleteAsync();
}
