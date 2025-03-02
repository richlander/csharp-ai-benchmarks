# mbcp-344 -- Count elements with odd factors in a range

## Text

Write a C# function to find number of elements with odd factors in a given range.

## Code

```csharp
public int CountOddSquares(int n, int m) 
{ 
    return (int)Math.Sqrt(m) - (int)Math.Sqrt(n - 1); 
}
```

## Test List

```csharp
Debug.Assert(CountOddSquares(5, 100) == 8);
```

```csharp
Debug.Assert(CountOddSquares(8, 65) == 6);
```

```csharp
Debug.Assert(CountOddSquares(2, 5) == 1);
```
