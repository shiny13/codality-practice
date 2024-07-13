namespace OddOccurrencesInArray;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        var input = new int[] { 9, 3, 9, 3, 9, 7, 9 };
        foreach (var val in input)
        {
            Console.Write($"{val} ");
        }
        Console.WriteLine();

        var sol = new Solution();
        var result = sol.Calculate(input);

        Console.WriteLine($"Result: {result}");
        Console.ReadKey();
    }
}