namespace BinaryGap;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Binary Gap.");
        var entries = new List<int>() { 1, 2, 9, 15, 32, 128, 144, 145, 147, 483, 647, 1041 };

        foreach (var entry in entries)
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"Calculating {entry} ...");
            var calc = new Solution();
            var gapVal = calc.CalculateGap(entry);

            Console.WriteLine($"Gap value: {gapVal}");
            Console.WriteLine("---------------------------------------");
        }

        Console.ReadKey();
    }
}
