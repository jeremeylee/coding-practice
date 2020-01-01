using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.CSharp.Graph
{
    class NumberIslands
    {
        public int NumIslands(char[][] grid)
        {
            if (grid == null || grid.Length == 0)
            {
                return 0;
            }

            int numIslands = 0;

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        numIslands += dfs(grid, i, j);
                    }
                }
            }

            return numIslands;
        }

        public int dfs(char[][] grid, int i, int j)
        {
            if (i < 0 || i >= grid.Length || j < 0 || j >= grid[0].Length || grid[i][j] == '0')
            {
                return 0;
            }

            grid[i][j] = '0';
            dfs(grid, i + 1, j);
            dfs(grid, i - 1, j);
            dfs(grid, i, j + 1);
            dfs(grid, i, j - 1);
            return 1;
        }
    }
}
