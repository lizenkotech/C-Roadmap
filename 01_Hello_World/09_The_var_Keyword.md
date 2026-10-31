# The var Keyword

## 1. What is it?

The `var` keyword lets the compiler determine a variable's type from the value assigned at declaration. The variable still has a fixed type.

## 2. Basic syntax

```csharp
var name = "Alex";
var age = 25;

Console.WriteLine(name);
Console.WriteLine(age);
```

## 3. Line-by-line explanation

- `var` lets the compiler infer the type.
- `"Alex"` makes `name` a `string`; `25` makes `age` an `int`.
- `var` does not mean the variable can later become any type.
- A `var` variable must be initialized when declared.

## 4. Important notes

- C# statements usually end with a semicolon (`;`).
- C# is case-sensitive: `WriteLine` and `writeline` are different.
- Use clear names to make code easier to understand.

## 5. Practice exercise

Declare a product name and a price using `var`, then print both values.

## 6. Check your understanding

- Can you explain what the example does?
- Can you change the example yourself?
