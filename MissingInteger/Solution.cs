using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingInteger;

internal class Solution
{
    public Solution() { }

    public int Calculate(int[] A)
    {
        if (A == null)
        {
            return 1;
        }

        int smallest = 1;
        var sorted = A.Where(x => x > 0).OrderBy(x => x).ToArray();

        if (sorted.Length == 0)
        {
            return smallest;
        }
        if (sorted.Length == 1)
        {
            if (sorted[0] != 1)
            {
                return smallest;
            }
            else
            {
                return smallest + 1;
            }
        }

        foreach (int val in sorted)
        {
            if (smallest == val)
            {
                smallest++;
            }
        }

        return smallest;
    }
}
