namespace CyclicRotation;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Cyclic Rotation");

        var inputs = new List<int[]>()
        {
            new int[] { 3, 8, 9, 7, 6 },
            new int[] { 6, 3, 8, 9, 7 },
            new int[] { 7, 6, 3, 8, 9 }
        };

        foreach (var input in inputs)
        {
            var sol = new Solution();
            var rotatedArr = sol.RotateArray(input, 1);

            foreach (var val in rotatedArr) 
            {
                Console.Write($"{val} ");
            }
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}