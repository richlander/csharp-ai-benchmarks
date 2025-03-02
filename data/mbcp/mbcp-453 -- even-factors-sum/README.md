# mbcp-453 -- Sum even factors of a number using Python function

## Text

Write a C# function to find the sum of even factors of a number.

## Code

```csharp
import System;

public class FactorCalculator
{
    public static int SumOfFactors(int n)
    {
        if (n % 2 != 0)
        {
            return 0;
        }
        int res = 1;
        for (int i = 2; i <= (int)Math.Sqrt(n); i++)
        {
            int count = 0;
            int currSum = 1;
            int currTerm = 1;
            while (n % i == 0)
            {
                count++;
                n /= i;
                if (i == 2 && count == 1)
                {
                    currSum = 0;
                }
                currTerm *= i;
                currSum += currTerm;
            }
            res *= currSum;
        }
        if (n >= 2)
        {
            res *= (1 + n);
        }
        return res;
    }
}
```

## Test List

```csharp
Debug.Assert(SumOfFactors(18) == 26);
```

```csharp
Debug.Assert(SumOfFactors(30) == 48);
```

```csharp
Debug.Assert(SumOfFactors(6) == 8);
```
