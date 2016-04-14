namespace Problem1CustomLINQExtensionMethods
{
    using System;
    using System.Collections.Generic;

    public static class Extensions
    {
        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            var filteredCollection = new List<T>();

            foreach (var element in collection)
            {
                if (!predicate(element))
                {
                   filteredCollection.Add(element); 
                }
            }

            return filteredCollection;
        }

        public static TSelector MaxElement<TSource, TSelector>(this IEnumerable<TSource> collection,
            Func<TSource, TSelector> condition) where TSelector : IComparable<TSelector>
        {
            var selectorCollection = new List<TSelector>();
            foreach (var item in collection)
            {
                selectorCollection.Add(condition(item));
            }

            var max = selectorCollection[0];
            for (int i = 0; i < selectorCollection.Count; i++)
            {
                if (max.CompareTo(selectorCollection[i]) < 0)
                {
                    max = selectorCollection[i];
                }
            }

            return max;
        }
    }
}