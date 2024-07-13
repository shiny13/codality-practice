using FrogJmp;

namespace FogJmp;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Frog Jump!");
        int X = 10, Y = 85, D = 30;

        Console.WriteLine($"X: {X} Y: {Y} D: {D}");
        var sol = new Solution();
        var jumps = sol.Calculate(X, Y, D);

        Console.WriteLine($"Jumps: {jumps}");

        Console.ReadKey();
    }
}