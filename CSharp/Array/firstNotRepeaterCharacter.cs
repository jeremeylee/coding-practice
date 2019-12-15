using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.CSharp.Array
{
    class firstNotRepeaterCharacter
    {
        char firstNotRepeatingCharacter(string s)
        {
            char[] characters = s.ToCharArray();

            for (int i = 0; i < characters.Length; i++)
            {
                if (Array.IndexOf(characters, characters[i]) == Array.LastIndexOf(characters, characters[i]))
                {
                    return characters[i];
                }
            }

            return '_';
        }

    }
}
