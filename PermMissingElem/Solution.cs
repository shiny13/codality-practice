using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermMissingElem
{
    internal class Solution
    {
        public Solution() { }

        public int Calculate(int[] A)
        {
            if (A == null || A.Length == 0)
            {
                return 1;
            }

            int missing = -1;

            var sorted = A.OrderBy(x => x).ToArray();
            for (int i = 0; i < sorted.Length-1; i++)
            {
                if ((sorted[i+1] - sorted[i] > 1))
                {
                    missing = sorted[i] + 1; 
                    break;
                }
            }

            if (missing == -1 && sorted[0] > 1)
            {
                missing = sorted[0] - 1;
            }
            else if (missing == -1)
            {
                missing = sorted[sorted.Length - 1] + 1;
            }

            return missing;
        }
    }
}
