using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogJmp
{
    internal class Solution
    {
        public Solution() { }

        public int Calculate(int X, int Y, int D)
        {
            // edge case for not needed to jump
            if (X == Y)
            {
                return 0;
            }

            int goal = Y - X;
            // edge case for 1 jump or a very large jump just once
            if (D >= goal)
            {
                return 1;
            }

            int jumps = goal / D;
            if (goal % D > 0)
            {
                jumps++;
            }

            return jumps;
        }

        // This solution will exceed the time limit, so no good!
        public int Calculate2(int X, int Y, int D)
        {
            var jumps = 0;
            if (X == Y)
            {
                return 0;
            }

            if (D >= Y - X)
            {
                return 1;
            }

            int position = X;
            while (position < Y)
            {
                position = position + D;
                jumps++;
            }

            return jumps;
        }
    }
}
