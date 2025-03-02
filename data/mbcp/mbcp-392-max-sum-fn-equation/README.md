# mbcp392 -- Find maximum sum using recursive function definition

## Text

Write a function to find the maximum sum possible by using the given equation f(n) = max( (f(n/2) + f(n/3) + f(n/4) + f(n/5)), n).

## Code

```csharp
public int GetMaxSum(int n)
{
    List<int> res = new List<int>();
    res.Add(0);
    res.Add(1);
    int i = 2;
    while (i < n + 1)
    {
        res.Add(Math.Max(i, res[i / 2] + res[i / 3] + res[i / 4] + res[i / 5]));
        i++;
    }
    return res[n];
}
```

## Test List

```csharp
Debug.Assert(GetMaxSum(60) == 106);
```

```csharp
Debug.Assert(GetMaxSum(10) == 12);
```

```csharp
Debug.Assert(GetMaxSum(2) == 2);
```
