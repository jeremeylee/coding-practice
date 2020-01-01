using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.CSharp.dp
{
    class CountingBits
    {
        public int[] CountBits(int num)
        {
            int[] output = new int[num + 1];
            for (int i = num; i >= 0; i--)
            {
                int x = i;
                while (x > 0)
                {
                    if (x % 2 == 1)
                    {
                        output[i]++;
                    }

                    x /= 2;
                }
            }

            return output;
        }
    }
}
