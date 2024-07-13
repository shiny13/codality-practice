using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOccurrencesInArray
{
    internal class Solution
    {
        public Solution() { }

        public int Calculate(int[] A)
        {
            var occurences = new Dictionary<int, int>();

            foreach (int val in A)
            {
                if (!occurences.ContainsKey(val))
                {
                    occurences[val] = 1;
                }
                else
                {
                    occurences.Remove(val);
                }
            }

            return occurences.ElementAtOrDefault(0).Key;
        }
    }
}
