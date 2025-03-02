# mbcp375 -- Round a number to the nearest specified multiple

## Text

Write a function to round the given number to the nearest multiple of a specific number.

## Code

```csharp
public static int RoundNum(int n, int m)
{
    int a = (n / m) * m;
    int b = a + m;
    return (n - a > b - n) ? b : a;
}
```

## Test List

```csharp
Debug.Assert(RoundNum(4722, 10) == 4720);
```

```csharp
Debug.Assert(RoundNum(1111, 5) == 1110);
```

```csharp
Debug.Assert(RoundNum(219, 2) == 218);
```
