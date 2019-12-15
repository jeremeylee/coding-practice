using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.CSharp
{
    class FirstDuplicate
    {
        int firstDuplicate(int[] a)
        {
            HashSet<int> duplicate = new HashSet<int>();

            for (int i = 0; i < a.Length; i++)
            {
                if (duplicate.Contains(a[i]))
                {
                    return a[i];
                }
                else
                {
                    duplicate.Add(a[i]);
                }
            }

            return -1;
        }
}
