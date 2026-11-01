// Verbatim Strings
// Verbatim strings treat backslashes as normal characters.

public static class Lesson07VerbatimStrings
{
    public static void Run()
    {
        string filePath = @"C:\Users\Alice\Documents";

        Console.WriteLine(filePath);
    }
}