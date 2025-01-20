public class RoleQuery : IQueryObject<Role>
{
    public string Name { get; set; }

    public IQueryable<Role> ApplyFilter(IQueryable<Role> query)
    {
        if (!string.IsNullOrEmpty(Name))
        {
            query = query.Where(r => r.Name.Contains(Name));
        }

        return query;
    }
}
