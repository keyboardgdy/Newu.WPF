public class UserQuery : IQueryObject<User>
{
    public string Name { get; set; }
    public string Account { get; set; }

    public IQueryable<User> ApplyFilter(IQueryable<User> query)
    {
        if (!string.IsNullOrEmpty(Name))
        {
            query = query.Where(u => u.Name.Contains(Name));
        }

        if (!string.IsNullOrEmpty(Account))
        {
            query = query.Where(u => u.Account.Contains(Account));
        }

        return query;
    }
}
