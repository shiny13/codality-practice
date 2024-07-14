namespace FrogRiverOne;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("FrogRiverOne");

        var X = 5;
        var A = new int[] { 1, 3, 1, 4, 2, 3, 5, 6 };

        Console.Write($"X: {X} | A: ");
        foreach (var val in A)
        {
            Console.Write($"{val} ");
        }
        Console.WriteLine();

        var sol = new Solution();
        var result = sol.Calculate(X, A);

        Console.WriteLine($"Position: {result}");
        Console.ReadKey();
    }
}
