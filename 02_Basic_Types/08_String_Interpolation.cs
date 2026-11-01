// String Interpolation
// Interpolation inserts variables into strings.

public static class Lesson08StringInterpolation
{
    public static void Run()
    {
        string firstName = "Alice";
        int age = 27;

        string message = $"My name is {firstName} and I am {age} years old.";

        Console.WriteLine(message);
    }
}