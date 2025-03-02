# mbcp-164 -- Check if sums of divisors are equal in Python

## Text

Write a C# function to check whether the sum of divisors are same or not.

## Code

```csharp
using System;

public class DivisorSumCalculator
{
    public static int DivSum(int n)
    {
        int sum = 1;
        int i = 2;
        while (i * i <= n)
        {
            if (n % i == 0)
            {
                sum += i + (int)Math.Floor(n / (double)i);
            }
            i++;
        }
        return sum;
    }

    public static bool AreEquivalent(int num1, int num2)
    {
        return DivSum(num1) == DivSum(num2);
    }
}
```

## Test List

```csharp
Debug.Assert(!AreEquivalent(36, 57));
```

```csharp
Debug.Assert(AreEquivalent(2, 4) == false);
```

```csharp
Debug.Assert(AreEquivalent(23, 47) == true);
```
