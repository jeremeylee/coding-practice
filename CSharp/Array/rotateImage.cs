using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.CSharp.Array
{
    class rotateImage
    {
        public void Rotate(int[][] matrix)
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = row; col < matrix[0].Length; col++)
                {
                    int temp = matrix[row][col];
                    matrix[row][col] = matrix[col][row];
                    matrix[col][row] = temp;
                }
            }

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[0].Length / 2; col++)
                {
                    int temp = matrix[row][col];
                    matrix[row][col] = matrix[row][matrix.Length - 1 - col];
                    matrix[row][matrix.Length - 1 - col] = temp;
                }
            }
        }
    }
}
