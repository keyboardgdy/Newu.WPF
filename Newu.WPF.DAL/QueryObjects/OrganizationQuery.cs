public class OrganizationQuery : IQueryObject<Organization>
{
    public string Name { get; set; }
    public string Leader { get; set; }

    public IQueryable<Organization> ApplyFilter(IQueryable<Organization> query)
    {
        if (!string.IsNullOrEmpty(Name))
        {
            query = query.Where(o => o.Name.Contains(Name));
        }

        if (!string.IsNullOrEmpty(Leader))
        {
            query = query.Where(o => o.Leader.Contains(Leader));
        }

        return query;
    }
}
