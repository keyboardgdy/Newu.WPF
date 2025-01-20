public class FunctionQuery : IQueryObject<Function>
{
    public string Name { get; set; }
    public string Code { get; set; }

    public IQueryable<Function> ApplyFilter(IQueryable<Function> query)
    {
        if (!string.IsNullOrEmpty(Name))
        {
            query = query.Where(f => f.Name.Contains(Name));
        }

        if (!string.IsNullOrEmpty(Code))
        {
            query = query.Where(f => f.Code.Contains(Code));
        }

        return query;
    }
}
