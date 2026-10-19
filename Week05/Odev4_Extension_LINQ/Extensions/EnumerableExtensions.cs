using System;

namespace Odev4_Extension_LINQ.Extensions;

public static class EnumerableExtensions
{
    public static bool HasAny<T>(
        this IEnumerable<T> source,
         Predicate<T> condition)
    {
        ArgumentNullException.ThrowIfNull(source);
        ArgumentNullException.ThrowIfNull(condition);

        foreach (T item in source)
        {
            if (condition(item))
            {
                return true;
            }
        }

        return false;
    }

    public static string JoinForDisplay<T>(
        this IEnumerable<T> source, 
        Func<T, string> formatter)
    {
        ArgumentNullException.ThrowIfNull(source);
        ArgumentNullException.ThrowIfNull(formatter);
        return string.Join(" | ", source.Select(formatter));
    }
    public static string SumFormatted(
       this IEnumerable<decimal> source,
       Func<decimal, string> formatter)
    {
        ArgumentNullException.ThrowIfNull(source);
        ArgumentNullException.ThrowIfNull(formatter);

        decimal total = source.Sum();

        return formatter(total);
    }
}
