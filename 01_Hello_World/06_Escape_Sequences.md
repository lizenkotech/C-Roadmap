# Escape Sequences

## 1. What is it?

Escape sequences are special character combinations used inside strings.

They begin with a backslash (`\`).

They allow you to add special characters to text.

## 2. Basic syntax

```csharp
string message = "Hello\nWorld";

Console.WriteLine(message);
```

Output:

```text
Hello
World
```

## 3. Common escape sequences

| Escape sequence | Meaning               |
| --------------- | --------------------- |
| `\n`            | New line              |
| `\t`            | Tab                   |
| `\\`            | Backslash             |
| `\"`            | Double quotation mark |
| `\r`            | Carriage return       |

## 4. Line-by-line explanation

- `string` declares a text variable.
- `message` is the variable name.
- `\n` creates a new line.
- `Console.WriteLine()` displays the text.

## 5. Important notes

- Escape sequences begin with a backslash.
- `\n` moves text to a new line.
- `\t` adds a tab space.
- `\"` allows quotation marks inside a string.

## 6. Practice exercise

Create a string that displays:

```text
Name: Alice
City: Diest
```

Use the `\n` escape sequence.

## 7. Check your understanding

- What is an escape sequence?
- Which escape sequence creates a new line?
- Which escape sequence adds a tab?
