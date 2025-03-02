# mbcp287 -- Sum of squares of first n even numbers

## Text

Write a C# function to find the sum of squares of first n even natural numbers.

## Code

```csharp
public int SquareSum(int n)  
{  
    return (int)(2 * n * (n + 1) * (2 * n + 1) / 3);  
}
```

## Test List

```csharp
Debug.Assert(SquareSum(2) == 20);
```

```csharp
Debug.Assert(SquareSum(3) == 56);
```

```csharp
Debug.Assert(SquareSum(4) == 120);
```
