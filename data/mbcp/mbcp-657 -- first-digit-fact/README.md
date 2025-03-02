# mbcp-657 -- Find the first digit in a factorial number

## Text

Write a C# function to find the first digit in factorial of a given number.

## Code

```csharp
using System;

public class Program
{
    public static int FirstDigit(int n)
    {
        long fact = 1;
        for (int i = 2; i <= n; i++)
        {
            fact *= i;
            while (fact % 10 == 0)
            {
                fact /= 10;
            }
        }
        while (fact >= 10)
        {
            fact /= 10;
        }
        return (int)Math.Floor(fact);
    }
}
```

## Test List

```csharp
Debug.Assert(FirstDigit(5) == 1);
```

```csharp
Debug.Assert(FirstDigit(10) == 3);
```

```csharp
Debug.Assert(FirstDigit(7) == 5);
```
