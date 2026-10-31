# Decimals

## 1. What is it?

The `decimal` data type stores numbers with decimal places.

It is especially useful for financial calculations, such as prices and money.

Examples:

- 12.50
- 99.99
- 1500.75

## 2. Basic syntax

```csharp
decimal productPrice = 19.99m;
decimal bankBalance = 250.50m;

Console.WriteLine(productPrice);
Console.WriteLine(bankBalance);
```

## 3. Line-by-line explanation

- `decimal` declares a variable that stores decimal numbers.
- `productPrice` is the variable name.
- `19.99m` is the assigned value.
- The letter `m` tells C# that the number is a decimal literal.
- `Console.WriteLine()` displays the value.

## 4. Important notes

- `decimal` is suitable for financial calculations.
- Decimal literals need the suffix `m` or `M`.
- `decimal` has higher decimal precision than `double`.
- `decimal` uses more memory than `float` and `double`.

## 5. Practice exercise

Create two decimal variables:

1. The price of a laptop.
2. The amount of money in a wallet.

Display both values.

## 6. Check your understanding

- What is `decimal` commonly used for?
- Why do we add `m` after a decimal literal?
- What is one difference between `decimal` and `double`?
