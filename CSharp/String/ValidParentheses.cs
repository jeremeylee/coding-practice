using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.CSharp.String
{
    class ValidParentheses
    {
        public bool IsValid(string s)
        {
            Stack<char> parens = new Stack<char>();
            Dictionary<char, char> parentheses = new Dictionary<char, char>();
            parentheses.Add(')', '(');
            parentheses.Add(']', '[');
            parentheses.Add('}', '{');

            for (int i = 0; i < s.Length; i++)
            {
                if (parentheses.ContainsKey(s[i]))
                {
                    if (parens.Count() == 0 || parentheses[s[i]] != parens.Peek())
                    {
                        return false;
                    }
                    else
                    {
                        parens.Pop();
                    }
                }
                else
                {
                    parens.Push(s[i]);
                }
            }

            return parens.Count() > 0 ? false : true;
        }
    }
}
