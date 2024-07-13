using System;

namespace TapeEquilibrium
{
    internal class Solution
    {
        public Solution() { }

        public int Calculate(int[] A)
        {
            int N = A.Length;

            int sum1 = A[0];
            int sum2 = 0;
            int P = 1;
            for (int i = P; i < N; i++)
            {
                sum2 += A[i];
            }
            int diff = Math.Abs(sum1 - sum2);

            for (; P < N - 1; P++)
            {
                sum1 += A[P];
                sum2 -= A[P];

                int newDiff = Math.Abs(sum1 - sum2);
                if (newDiff < diff)
                {
                    diff = newDiff;
                }
            }
            return diff;
        }
    }
}
