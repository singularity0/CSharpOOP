using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.IEnumExtensions
{
    class IEnumExt
    {
        static void Main()
        {
            List<int> collection = new List<int> { 1, 2, 3, 4 };
            Console.WriteLine(collection.Sum<int>());
            Console.WriteLine(collection.Product<int>());
            Console.WriteLine(collection.Min<int>());
            Console.WriteLine(collection.Max<int>());
            Console.WriteLine(collection.Average<int>());




        }
    }

    public static class IEnumExts
    {
        public static T Sum<T>(this IEnumerable<T> collection ) where T : IConvertible
        {
            T result = default(T);
            foreach (var number in collection)
            {
                result += (dynamic)number;
            }

            return result;
        }

        public static T Product<T>(this IEnumerable<T> coll) where T : IConvertible
        {
            dynamic result = 1;
            foreach (var number in coll)
            {
                result *= (dynamic)number;
            }

            return result;
        }


        public static T Min<T>(this IEnumerable<T> coll) where T : IConvertible
        {
            T min = (dynamic)coll.ElementAt(0);

            foreach (var number in coll)
            {
                if ((dynamic)number < min)
                {
                    min = number;
                }
            }

            return min;
        }

        public static T Max<T>(this IEnumerable<T> coll) where T : IConvertible
        {
            T max = (dynamic)coll.ElementAt(0);

            foreach (var number in coll)
            {
                if ((dynamic)number > max)
                {
                    max = number;
                }
            }

            return max;
        }

        public static double Average<T>(this IEnumerable<T> collection) where T : IConvertible
        {

            T average = default(T);
            float length = 0;

            foreach (var number in collection)
            {
                average += (dynamic)number;
                length++;
            }

            return ((dynamic) average / length);
        }
    }
}
