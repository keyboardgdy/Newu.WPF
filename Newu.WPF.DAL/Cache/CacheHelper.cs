public static class CacheHelper
{
    private static readonly Dictionary<string, object> _cache = new Dictionary<string, object>();

    public static void AddToCache(string key, object value)
    {
        _cache[key] = value;
    }

    public static object GetFromCache(string key)
    {
        _cache.TryGetValue(key, out var value);
        return value;
    }

    public static void RemoveFromCache(string key)
    {
        _cache.Remove(key);
    }
}
