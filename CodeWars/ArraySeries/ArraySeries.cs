using System.Collections.Generic;
using System.Linq;

namespace CodeWars.ArraySeries
{
    public class ArraySeries
    {
        public static int MinSum(int[] a)
        {
            var list = new List<int>(a);
            var n = list.Count() / 2;
            var productList = new List<int>();
            for (var i = 0; i < n; i++)
            {
                var min = list.Min();
                list.Remove(min);
                var max = list.Max();
                list.Remove(max);
                var product = min * max;
                productList.Add(product);
            }

            return productList.Sum();
        }

        public static int NthSmallest(int[] arr, int pos)
        {
            return arr.OrderBy(x => x).ElementAtOrDefault(pos - 1);
        }

        public static int MaxProduct(int[] numbers, int size)
        {
            var orderedStack = new Stack<int>(numbers.OrderBy(x => x));
            var result = orderedStack.Pop();

            for (var i = 0; i < size - 1; i++)
            {
                result *= orderedStack.Pop();
            }

            return result;
        }
    }
}