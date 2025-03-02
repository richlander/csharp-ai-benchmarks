# mbcp663 -- Find the largest k where k mod x equals y

## Text

Write a function to find the largest possible value of k such that k modulo x is y.

## Code

```csharp
public int FindMaxVal(int n, int x, int y) 
{
    int ans = int.MinValue;
    for (int k = 0; k <= n; k++) 
    {
        if (k % x == y) 
        {
            ans = Math.Max(ans, k);
        }
    }
    return (ans >= 0 && ans <= n) ? ans : -1;
}
```

## Test List

```csharp
Debug.Assert(FindMaxVal(15, 10, 5) == 15);
```

```csharp
Debug.Assert(FindMaxVal(187, 10, 5) == 185);
```

```csharp
Debug.Assert(FindMaxVal(16, 11, 1) == 12);
```
