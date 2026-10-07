namespace AcademiaSystem.Models;
public static class ConsoleLogger
{
    public static void log(string message)
    {
        Console.WriteLine($"[LOG] {message}");
    }
    public static void warn(string message)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"[WARN] {message}");
        Console.ResetColor();
    }

    public static void error(string message)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine($"[ERROR] {message}");
        Console.ResetColor();
    }
}