using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclicRotation;

internal class Solution
{
    public Solution() { }

    public int[] RotateArray(int[] A, int K)
    {
        if (A == null || A.Length == 0)
        {
            return new int[0];
        }
        else if (A.Length == K)
        {
            return A;
        }
        else if (K == 0)
        {
            return A;
        }
        else if (A.Length == 1)
        {
            return A;
        }

        if (K > A.Length)
        {
            K = K % A.Length;   
        }

        var rotatedArr = new int[A.Length];
        for (int i = 0; i < A.Length; i++)
        {
            var rotatedIndex = i + K;
            if (rotatedIndex < A.Length)
            {
                rotatedArr[rotatedIndex] = A[i];
            }
            else
            {
                rotatedIndex = rotatedIndex - A.Length;
                rotatedArr[rotatedIndex] = A[i];
            }
        }

        return rotatedArr;
    }
}
