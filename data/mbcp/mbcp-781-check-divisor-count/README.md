# mbcp781 -- Check if the count of divisors is even or odd

## Text

Write a C# function to check whether the count of divisors is even or odd.

## Code

```csharp
using System;

public class Program
{
    public static string CountDivisors(int n) 
    {
        int count = 0;
        for (int i = 1; i <= (int)(Math.Sqrt(n)) + 1; i++) 
        {
            if (n % i == 0) 
            {
                if (n / i == i) 
                {
                    count++;
                }
                else 
                {
                    count += 2;
                }
            }
        }
        return (count % 2 == 0) ? "Even" : "Odd";
    }
}
```

## Test List

```csharp
Debug.Assert(CountDivisors(10) == "Even");
```

```csharp
Debug.Assert(CountDivisors(100) == "Odd");
```

```csharp
Debug.Assert(CountDivisors(125) == "Even");
```
