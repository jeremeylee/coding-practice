using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.CSharp.Array
{
    class rotateImage
    {
        int[][] rotateImage(int[][] a)
        {
            for (int i = 0; i < a[0].Length; i++)
            {
                for (int j = i; j < a[0].Length; j++)
                {
                    int temp = a[i][j];
                    a[i][j] = a[j][i];
                    a[j][i] = temp;
                }
            }

            for (int i = 0; i < a[0].Length; i++)
            {
                for (int j = 0; j < a[0].Length / 2; j++)
                {
                    int temp = a[i][j];
                    a[i][j] = a[i][a.Length - 1 - j];
                    a[i][a.Length - 1 - j] = temp;
                }
            }
            return a;
        }

    }
}
