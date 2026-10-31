// Console.ReadLine
// The explanation and practice exercise are in 04_Console_ReadLine.md.

public static class Lesson04ConsoleReadline
{
    public static void Run()
    {
        Console.Write("What is your name? ");
        string? name = Console.ReadLine();
        Console.WriteLine($"Hello, {name}!");
    }
}
