namespace PermMissingElem;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("PermMissingElem");

        var input = new int[] { 2, 3, 1, 5 };
        foreach(var val in input)
        {
            Console.Write($"{val} ");
        }
        Console.WriteLine();

        var sol = new Solution();
        var missing = sol.Calculate(input);
        Console.WriteLine($"missing: {missing}");
        Console.ReadKey();
    }
}