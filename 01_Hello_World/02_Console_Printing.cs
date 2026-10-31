// =====================================
// LESSON: CONSOLE.WRITE VS CONSOLE.WRITELINE
// =====================================

// 1. Console.WriteLine()

Console.WriteLine("Hello");
Console.WriteLine("World");

// 2. Console.Write()

Console.Write("Hello");
Console.Write("World");

// 3. Combining both methods

Console.Write("Name: ");
Console.WriteLine("Alice");

// 4. Combining text and numbers

Console.Write("Score: ");
Console.Write(100);
Console.WriteLine(" points");



public class Solution
{
    public static void PrintGreeting()
    {
        // Use Console.Write to print without adding a newline
        Console.Write("Hello, ");
        // Then use Console.WriteLine to complete the message
        Console.WriteLine("World!");
    }
}