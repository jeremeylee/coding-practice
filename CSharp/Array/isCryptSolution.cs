using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.CSharp.Array
{
    class isCryptSolution
    {
        bool isCryptSolution(string[] crypt, char[][] solution)
        {
            long[] values = new long[crypt.Length];
            for (int i = 0; i < crypt.Length; i++)
            {
                string decrypt = getNumber(crypt[i], solution);
                Console.WriteLine(decrypt);
                if (String.Equals(decrypt[0], '0') && decrypt.Length > 1)
                {
                    return false;
                }
                values[i] = Int64.Parse(decrypt);

            }

            return (values[0] + values[1]) == values[2];
        }

        string getNumber(string crypt, char[][] solution)
        {
            string result = "";

            for (int i = 0; i < crypt.Length; i++)
            {
                for (int j = 0; j < solution.Length; j++)
                {
                    if (solution[j][0] == crypt[i])
                    {
                        result = String.Concat(result, Char.ToString(solution[j][1]));

                    }
                }
            }

            return result;
        }
    }
}
