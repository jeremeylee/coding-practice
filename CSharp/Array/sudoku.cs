using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.CSharp.Array
{
    class sudoku
    {
        bool sudoku2(char[][] grid)
        {
            bool valid = true;

            for (int row = 0; row < grid.Length; row++)
            {
                HashSet<char> unique = new HashSet<char>();
                unique.Clear();
                for (int col = 0; col < grid[0].Length; col++)
                {
                    if (unique.Contains(grid[row][col]) && !Char.Equals(grid[row][col], '.'))
                    {
                        Console.WriteLine("here1");
                        return false;
                    }
                    else
                    {
                        unique.Add(grid[row][col]);
                    }
                }
            }

            for (int col = 0; col < grid[0].Length; col++)
            {
                HashSet<char> unique = new HashSet<char>();
                unique.Clear();
                for (int row = 0; row < grid.Length; row++)
                {
                    if (unique.Contains(grid[row][col]) && !Char.Equals(grid[row][col], '.'))
                    {
                        Console.WriteLine("here2");
                        return false;
                    }
                    else
                    {
                        unique.Add(grid[row][col]);
                    }
                }
            }

            for (int col = 0; col < 3; col++)
            {
                for (int row = 0; row < 3; row++)
                {
                    valid = subGrid(grid, 3 * row, 3 * col);
                    if (!valid)
                    {
                        Console.WriteLine("here3");
                        return false;
                    }
                }
            }

            return valid;

        }

        bool subGrid(char[][] grid, int startRow, int startCol)
        {
            HashSet<char> unique = new HashSet<char>();

            for (int row = startRow; row < startRow + 3; row++)
            {
                for (int col = startCol; col < startCol + 3; col++)
                {
                    if (unique.Contains(grid[row][col]) && !Char.Equals(grid[row][col], '.'))
                    {
                        return false;
                    }
                    else
                    {
                        unique.Add(grid[row][col]);
                    }
                }
            }

            return true;
        }

    }
}
