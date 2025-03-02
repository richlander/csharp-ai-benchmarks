# mbcp687 -- Find gcd of two integers using recursion

## Text

Write a function to find the greatest common divisor (gcd) of two integers by using recursion.

## Code

```csharp
public int RecurGcd(int a, int b)
{
    int low = Math.Min(a, b);
    int high = Math.Max(a, b);
    if (low == 0)
        return high;
    else if (low == 1)
        return 1;
    else
        return RecurGcd(low, high % low);
}
```

## Test List

```csharp
Debug.Assert(RecurGcd(12, 14) == 2);
```

```csharp
Debug.Assert(RecurGcd(13, 17) == 1);
```

```csharp
Debug.Assert(RecurGcd(9, 3) == 3);
```
