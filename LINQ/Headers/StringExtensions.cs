namespace LINQ.Headers;

public static partial class StringExtensions
{
    public static void Print(this string source)
    {
        Console.WriteLine(source);
    }

    public static partial string Repeat(this string source, int count);
}