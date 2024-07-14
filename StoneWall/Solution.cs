using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoneWall;

internal class Solution
{
    public Solution() { }

    public int Calculate(int[] H)
    {
        int result = 0;

        var stack = new Stack<int>();
        foreach (int newWallHeight in H)
        {
            while (stack.Count != 0)
            {
                int preStone = stack.Pop();
                if (preStone == newWallHeight)
                {
                    stack.Push(preStone);
                    break;
                }
                else if (newWallHeight > preStone)
                {
                    stack.Push(preStone);
                    stack.Push(newWallHeight);
                    break;
                }
                else
                {
                    result++;
                }
            }

            if (stack.Count != 0)
            {
                stack.Push(newWallHeight);
            }
        }

        return result + stack.Count;
    }
}
