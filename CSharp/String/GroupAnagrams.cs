using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.CSharp.String
{
    class GroupAnagrams
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, int> map = new Dictionary<string, int>();
            List<IList<string>> res = new List<IList<string>>();

            for (int i = 0; i < strs.Length; i++)
            {
                char[] charArray = strs[i].ToCharArray();
                Array.Sort(charArray);
                string str = new string(charArray);
                if (!map.ContainsKey(str))
                {
                    map.Add(str, res.Count);
                    res.Add(new List<string>());
                }

                res[map[str]].Add(strs[i]);
            }

            return res;

        }
    }
}
