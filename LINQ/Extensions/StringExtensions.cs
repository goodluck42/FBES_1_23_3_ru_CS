using LINQ.Headers;
using System.Linq;
using System;
using System.Text;

namespace LINQ.Headers;

public static partial class StringExtensions
{
    public static partial string Repeat(this string source, int count)
    {
        var builder = new StringBuilder();

        for (int i = 0; i < count; i++)
        {
            builder.Append(source);
        }
        
        return builder.ToString();
    }
}