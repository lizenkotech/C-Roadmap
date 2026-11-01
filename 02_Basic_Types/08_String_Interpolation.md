# String Interpolation

## 1. What is it?

String interpolation allows you to insert variables and expressions directly into a string.

In C#, string interpolation starts with the `$` symbol.

Variables are placed inside curly braces `{}`.

## 2. Basic syntax

```csharp
string firstName = "Alice";
int age = 27;

string message = $"My name is {firstName} and I am {age} years old.";

Console.WriteLine(message);
```

## 3. Line-by-line explanation

- `string` declares a text variable.
- `int` declares an integer variable.
- `$` enables string interpolation.
- `{firstName}` inserts the value of the variable.
- `{age}` inserts the age into the text.
- `Console.WriteLine()` displays the result.

## 4. Important notes

- String interpolation starts with `$`.
- Variables are placed inside `{}`.
- You can insert different data types.
- Interpolation makes it easier to combine text and variables.

## 5. Practice exercise

Create:

1. A string variable containing your name.
2. An integer variable containing your age.

Use string interpolation to display both values in one sentence.

## 6. Check your understanding

- Which symbol enables string interpolation?
- Where do you place variables inside an interpolated string?
- Can you insert an integer into an interpolated string?
