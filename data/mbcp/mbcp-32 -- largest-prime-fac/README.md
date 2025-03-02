# mbcp-32 -- Find largest prime factor of a number in Python

## Text

Write a C# function to find the largest prime factor of a given number.

## Code

```csharp
using System;

public class PrimeFactors
{
    public static int MaxPrimeFactors(int n)
    {
        int maxPrime = -1;
        while (n % 2 == 0)
        {
            maxPrime = 2;
            n >>= 1;
        }
        for (int i = 3; i <= Math.Sqrt(n); i += 2)
        {
            while (n % i == 0)
            {
                maxPrime = i;
                n /= i;
            }
        }
        if (n > 2)
        {
            maxPrime = n;
        }
        return maxPrime;
    }
}
```

## Test List

```csharp
Debug.Assert(MaxPrimeFactors(15) == 5);
```

```csharp
Debug.Assert(MaxPrimeFactors(6) == 3);
```

```csharp
Debug.Assert(MaxPrimeFactors(2) == 2);
```
