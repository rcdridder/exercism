﻿namespace Exercism.Enumerables
{
    public static class AccumulateEnum
    {
        public static IEnumerable<U> Accumulate<T, U>(this IEnumerable<T> collection, Func<T, U> func)
        {
            foreach (T item in collection)
            {
                yield return func(item);
            }
            yield break;
        }
    }
}
