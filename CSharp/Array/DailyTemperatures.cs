using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.CSharp.Array
{
    class DailyTemperatures
    {
        public int[] DailyTemperatures(int[] T)
        {
            int[] output = new int[T.Length];
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < T.Length; i++)
            {
                while (stack.Count != 0 && T[i] > T[stack.Peek()])
                {
                    int idx = stack.Pop();
                    output[idx] = i - idx;
                }
                stack.Push(i);
            }

            return output;
        }
    }
}
