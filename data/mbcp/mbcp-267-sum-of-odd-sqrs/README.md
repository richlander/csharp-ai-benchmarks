# mbcp267 -- Sum of squares of first n odd natural numbers

## Text

Write a C# function to find the sum of squares of first n odd natural numbers.

## Code

```csharp
public int SquareSum(int n)  
{  
    return (int)(n * (4 * n * n - 1) / 3);  
}
```

## Test List

```csharp
Debug.Assert(SquareSum(2) == 10);
```

```csharp
Debug.Assert(SquareSum(3) == 35);
```

```csharp
Debug.Assert(SquareSum(4) == 84);
```
