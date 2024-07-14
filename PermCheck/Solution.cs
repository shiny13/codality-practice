using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermCheck;

internal class Solution
{
    public Solution() { }

    public int Calculate(int[] A)
    {
        if (A.Length == 0)
        {
            return 0;
        }

        int permutation = 1;
        var sorted = A.OrderBy(x => x).ToArray();

        for (int i = 0; i < sorted.Length-1; i++)
        {
            if ((sorted[i]+1) != sorted[i+1])
            {
                permutation = 0;
                break;
            }
        }

        if (permutation == 1 && sorted[0] > 1)
        {
            permutation = 0;
        }

        return permutation;
    }
}
