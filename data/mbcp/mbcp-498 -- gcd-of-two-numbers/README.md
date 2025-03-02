# mbcp-498 -- Calculate the greatest common divisor of two numbers

## Text

Write a C# function to find gcd of two positive integers.

## Code

```csharp
public int Gcd(int x, int y) 
{
    int gcd = 1;
    if (x % y == 0)
    {
        return y;
    }
    for (int k = y / 2; k > 0; k--)
    {
        if (x % k == 0 && y % k == 0)
        {
            gcd = k;
            break;
        }
    }
    return gcd;
}
```

## Test List

```csharp
Debug.Assert(Gcd(12, 17) == 1);
```

```csharp
Debug.Assert(Gcd(4, 6) == 2);
```

```csharp
Debug.Assert(Gcd(2, 9) == 1);
```
