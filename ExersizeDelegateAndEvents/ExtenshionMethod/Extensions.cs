using System;
using System.Collections.Generic;

namespace ExtenshionMethod
{
    public static class Extensions
    {
        public static IEnumerable<T> Filter<T>(this IEnumerable<T> collection, Func<T, bool> filterConditional)
        {
            var result = new List<T>();
            foreach (var element in collection)
            {
                if (filterConditional(element))
                {
                    result.Add(element);
                }
            }

            return result;
        }

        public static T FirstOrDefault2<T>(this IEnumerable<T> collection, Predicate<T> conditional)
        {
            foreach (var element in collection)
            {
                if (conditional(element))
                {
                    return element;
                }
            }

            return default(T);
        }

        public static TSelector Max<TSource, TSelector>(this IEnumerable<TSource> collection, Func<TSource, TSelector> conditional)
            where TSelector : IComparable<TSelector>
        {
            var result = new List<TSelector>();
            foreach (var element in collection)
            {
                result.Add(conditional(element));
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


        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T, bool> resultCollect)
        {
            var result = new List<T>();
            foreach (var el in collection)
            {
                if (!resultCollect(el))
                {
                    result.Add(el);
                }
            }

            return result;
        }

        public static IEnumerable<K> OrderEnumerable<T, K>(this IList<T> collection, Func<T, K> conditional)
            where K : IComparable
        {
            var result = new List<K>();
            foreach (var el in collection)
            {
                result.Add(conditional(el));
            }

            var orderedList = new List<K>();

            for (int i = 0; i < result.Count; i++)
            {
                for (int j = i + 1; j < result.Count; j++)
                {
                    if (result[i].CompareTo(result[j]) > 0)
                    {
                        K swapNumber = result[i];
                        result[i] = result[j];
                        result[j] = swapNumber;
                    }
                }

                orderedList.Add(result[i]);
            }

            return orderedList;
        }

        public static IEnumerable<K> Project<K, T>(this IEnumerable<T> collection, Func<T, K> projectileCollection)
        {
            var result = new List<K>();
            foreach (var element in collection)
            {
                var project = projectileCollection(element);
                result.Add(project);
            }

            return result;
        }
    }
}
