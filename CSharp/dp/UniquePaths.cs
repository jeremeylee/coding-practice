using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.CSharp.dp
{
    class UniquePaths
    {
        public int UniquePaths(int m, int n)
        {
            int[,] output = new int[n, m];
            for (int i = 0; i < m; i++)
            {
                output[0, i] = 1;
            }

            for (int i = 0; i < n; i++)
            {
                output[i, 0] = 1;
            }

            for (int row = 1; row < n; row++)
            {
                for (int col = 1; col < m; col++)
                {
                    output[row, col] = output[row - 1, col] + output[row, col - 1];
                }
            }

            return output[n - 1, m - 1];

        }
    }
}
