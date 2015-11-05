using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YieldFibonacci
{
    public class Fibonacci
    {
        public static IEnumerable<int> GetSequence(int count)
        {
            if (count == 0)
                throw new ArgumentException();
            int a = 0;
            int b = 1;
            for (int i = 1; i <= count; ++i)
            {
                yield return b;
                b += a;
                a = b - a;
            }
        }
    }
}
