# mbcp325 -- Find minimum squares summing to a target number

## Text

Write a C# function to find the minimum number of squares whose sum is equal to a given number.

## Code

```csharp
public int GetMinSquares(int n)
{
    if (n <= 3)
    {
        return n;
    }
    int res = n;
    for (int x = 1; x <= n; x++)
    {
        int temp = x * x;
        if (temp > n)
        {
            break;
        }
        else
        {
            res = Math.Min(res, 1 + GetMinSquares(n - temp));
        }
    }
    return res;
}
```

## Test List

```csharp
Debug.Assert(GetMinSquares(6) == 3);
```

```csharp
Debug.Assert(GetMinSquares(2) == 2);
```

```csharp
Debug.Assert(GetMinSquares(4) == 1);
```
