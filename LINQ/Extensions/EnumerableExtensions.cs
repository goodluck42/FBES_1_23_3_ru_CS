namespace LINQ.Headers;

public static class EnumerableExtensions
{
    public static void Print<T>(this IEnumerable<T> source)
    {
        foreach (var value in source)
        {
            Console.WriteLine(value);
        }
    }

    public static IEnumerable<T> MyWhere<T>(this IEnumerable<T> source, Predicate<T> predicate)
    {
        foreach (var value in source)
        {
            if (predicate(value))
            {
                yield return value;
            }
        }
    }
}