using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.CSharp.Array
{
    class FibonacciNumber
    {
        public int Fib(int N)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < N; i++)
            {
                int c = a + b;
                b = a;
                a = c;
            }

            return a;
        }
    }
}
