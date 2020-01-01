using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.CSharp.Graph
{
    class TownJudge
    {
        public int FindJudge(int N, int[][] trust)
        {
            if (trust.Length < 1)
            {
                return 1;
            }

            int[] indegree = new int[N + 1];
            HashSet<int> trusts = new HashSet<int>();

            for (int i = 0; i < trust.Length; i++)
            {
                indegree[trust[i][1]]++;
                if (!trusts.Contains(trust[i][0]))
                {
                    trusts.Add(trust[i][0]);
                }
            }

            for (int i = 0; i <= N; i++)
            {

                if (indegree[i] == (N - 1) && !trusts.Contains(i))
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
