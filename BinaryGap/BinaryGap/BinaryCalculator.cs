using System.Diagnostics.Metrics;
using System.Linq;

namespace BinaryGap;

internal class BinaryCalculator
{
    public BinaryCalculator()
    {
    }

    public int CalculateGap(int n)
    {
        var gap = new List<int>();
        gap.Add(0);

        string value = Convert.ToString(n, 2);
        Console.WriteLine($"Input: {n} | Binary value: {value}");

        var binaryArray = new List<char>();
        var counter = 0;
        foreach(char c in value)
        {
            binaryArray.Add(c);
            Console.Write($"{binaryArray[counter]} ");
            counter++;
        }
        Console.WriteLine();

        int firstOne = -1;
        int secondOne = -1;

        for (int i = 0; i < binaryArray.Count; i++)
        {
            if (binaryArray[i] == '1' && firstOne == -1)
            {
                firstOne = i;
                Console.WriteLine($"binary value: {binaryArray[i]} | firstOne: {firstOne}");
            }
            else if (binaryArray[i] == '1' && firstOne >= 0)
            {
                secondOne = i;
                Console.WriteLine($"binary value: {binaryArray[i]} | secondOne: {secondOne}");
                if ((secondOne - (firstOne+1)) > 0)
                {
                    gap.Add((secondOne - (firstOne + 1)));
                }

                firstOne = i;
            }
        }

        return gap.Max();
    }
}
