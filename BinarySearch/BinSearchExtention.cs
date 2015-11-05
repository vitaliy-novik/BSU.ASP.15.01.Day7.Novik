using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    public static class BinSearchExtention
    {
        public static int BinSearsh<T>(this T[] array, T item, IComparer<T> comparer)
        {
            Func<T, T, int> compare;
            if (comparer == null)
            {
                IComparable<T> comp = item as IComparable<T>;
                if (comp != null)
                    compare = (c, t) => comp.CompareTo(t);
                else
                    throw new ArgumentException();
            }
            else
                compare = (c, t) => comparer.Compare(c, t);

            int start = 0, finish = array.Length;
            int middle;
            while (finish > start)
            {
                middle = start + (finish - start) / 2;
                if (compare(item, array[middle]) == 0)
                    return middle;
                if (compare(item, array[middle]) < 0)
                    finish = middle;
                else
                    start = middle + 1;
            }
            return -(start + 1);
        }
    }
}
