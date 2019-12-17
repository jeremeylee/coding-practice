using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.CSharp.dp
{
    class ClimbStairs
    {
        public int ClimbStairs(int n)
        {
            int a = 1;
            int b = 0;
            for (int i = 0; i < n; i++)
            {
                int c = a + b;
                b = a;
                a = c;
            }

            return a;
        }
    }
}
