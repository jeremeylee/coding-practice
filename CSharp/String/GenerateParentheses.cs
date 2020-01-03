using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.CSharp.String
{
    class GenerateParentheses
    {
        public IList<string> GenerateParenthesis(int n)
        {
            IList<string> list = new List<string>();
            helper(n, list, "", 0, 0);
            return list;
        }

        public void helper(int n, IList<string> list, string tempString, int open, int close)
        {
            if (tempString.Length == n * 2)
            {
                list.Add(tempString);
                return;
            }

            if (open < n)
            {
                helper(n, list, tempString + "(", open + 1, close);
            }
            if (close < open)
            {
                helper(n, list, tempString + ")", open, close + 1);
            }
            return;
        }
    }
}
