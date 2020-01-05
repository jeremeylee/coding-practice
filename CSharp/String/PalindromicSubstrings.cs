using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.CSharp.String
{
    class PalindromicSubstrings
    {
        public int CountSubstrings(string s)
        {
            if (s == null || s.Length == 1)
            {
                return 1;
            }

            int count = 0;

            for (int i = 0; i < s.Length; i++)
            {
                count += expand(s, i, i);
                count += expand(s, i, i + 1);
            }

            return count;
        }

        public int expand(string s, int left, int right)
        {
            int count = 0;
            while (left >= 0 && right < s.Length && (s[left] == s[right]))
            {
                count++;
                left--;
                right++;
            }

            return count;
        }
    }
}
