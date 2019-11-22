using System.Collections.Generic;
using System.Linq;

namespace TricksAspNetCore
{
    public static class EnumerableExtensions
    {
        // This extension helps to avoid null checking against Enumerable
        public static IEnumerable<T> OrEmptyIfNull<T>(this IEnumerable<T> source) =>
            source ?? Enumerable.Empty<T>();


        // Using foreach with index
        public static IEnumerable<(T item, int index)> WithIndex<T>(this IEnumerable<T> source) =>
            source.Select((item, index) => (item, index));
    }    
}
