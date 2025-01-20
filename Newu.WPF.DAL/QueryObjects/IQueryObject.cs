public interface IQueryObject<T>
{
    IQueryable<T> ApplyFilter(IQueryable<T> query);
}
