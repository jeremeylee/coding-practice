using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.CSharp.Array
{
    class LengthOfLongestSubstring
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (s.Length < 1)
            {
                return 0;
            }

            int longest = 1;
            int curr = 1;
            int[] visited = new int[256];

            for (int i = 0; i < visited.Length; i++)
            {
                visited[i] = -1;
            }

            visited[s[0]] = 0;
            for (int i = 1; i < s.Length; i++)
            {
                int prevIndex = visited[s[i]];

                if (prevIndex == -1 || i - prevIndex > curr)
                {
                    curr++;
                }
                else
                {
                    longest = Math.Max(longest, curr);
                    curr = i - prevIndex;
                }

                visited[s[i]] = i;
            }

            return Math.Max(longest, curr);
        }
    }
}
