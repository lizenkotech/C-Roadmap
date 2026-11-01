# Verbatim Strings

## 1. What is it?

A verbatim string is a string that starts with `@`.

It tells C# to treat backslashes as normal characters instead of escape characters.

Verbatim strings are useful for file paths and text containing backslashes.

## 2. Basic syntax

```csharp
string filePath = @"C:\Users\Alice\Documents";

Console.WriteLine(filePath);
```

## 3. Line-by-line explanation

- `string` declares a text variable.
- `filePath` is the variable name.
- `@` creates a verbatim string.
- The backslashes are treated as normal characters.
- `Console.WriteLine()` displays the file path.

## 4. Important notes

- A verbatim string starts with `@`.
- Backslashes do not need to be escaped.
- Verbatim strings can contain line breaks.
- To include a double quotation mark inside a verbatim string, write it twice: `""`.

## 5. Practice exercise

Create a verbatim string containing a Windows-style file path.

Display the path using `Console.WriteLine()`.

## 6. Check your understanding

- Which symbol starts a verbatim string?
- Why are verbatim strings useful for file paths?
- How do you write a quotation mark inside a verbatim string?
