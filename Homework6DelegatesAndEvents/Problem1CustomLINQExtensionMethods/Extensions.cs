using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem1CustomLINQExtensionMethods
{
    public static class Extensions
    {
        public static IEnumerable<T> WhereNot<T>(
            this IEnumerable<T> collection, 
            Func<T, bool> predicate)
        {
            return (
                from item in collection let shouldSave = predicate(item)
                where !shouldSave
                select item
                ).ToList();
        }

        public static TSelector Max<TSource, TSelector>(
            this IEnumerable<TSource> collection,
            Func<TSource, TSelector> selectFunc)
            where TSelector : IComparable<TSelector>
        {
            {
                var result = new List<TSelector>();
                foreach (var element in collection)
                {
                    result.Add(selectFunc(element));
                }

                var max = result[0];
                for (var i = 1; i < result.Count; i++)
                {
                    if (result[i].CompareTo(max) > 0)
                    {
                        max = result[i];
                    }
                }

                return max;
            }
        }

    }
}
