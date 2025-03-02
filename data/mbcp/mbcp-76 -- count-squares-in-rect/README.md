# mbcp-76 -- Count squares in a rectangle using a Python function

## Text

Write a C# function to count the number of squares in a rectangle.

## Code

```csharp
public int CountSquares(int m, int n) {
    if (n < m) {
        int temp = m;
        m = n;
        n = temp;
    }
    return (int)((m * (m + 1) * (2 * m + 1) / 6) + ((n - m) * m * (m + 1) / 2));
}
```

## Test List

```csharp
Debug.Assert(CountSquares(4, 3) == 20);
```

```csharp
Debug.Assert(CountSquares(2, 2) == 5);
```

```csharp
Debug.Assert(CountSquares(1, 1) == 1);
```
