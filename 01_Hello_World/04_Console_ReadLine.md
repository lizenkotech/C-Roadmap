# Console.ReadLine

## 1. What is it?

`Console.ReadLine()` waits for the user to type something and press Enter. It returns the entered text as a string.

## 2. Basic syntax

```csharp
Console.Write("What is your name? ");
string? name = Console.ReadLine();
Console.WriteLine($"Hello, {name}!");
```

## 3. Line-by-line explanation

- `Console.Write()` displays the question without starting a new line.
- `Console.ReadLine()` waits for input.
- The input is stored in the `name` variable.
- `$"...{name}..."` inserts a variable into text.
- `string?` indicates that the value may be `null`.

## 4. Important notes

- C# statements usually end with a semicolon (`;`).
- C# is case-sensitive: `WriteLine` and `writeline` are different.
- Use clear names to make code easier to understand.

## 5. Practice exercise

Ask for the user's favourite colour, store it in a variable and print a sentence containing it.

## 6. Check your understanding

- Can you explain what the example does?
- Can you change the example yourself?
