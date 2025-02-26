# 3 -- Function to check non-prime numbers

nonprime_check

## Prompt

Write a C# function to identify non-prime numbers.

## Solution

```csharp
using System;
using System.Diagnostics;

bool IsNotPrime(int n)
{
    bool result = false;
    for (int i = 2; i <= (int)Math.Sqrt(n); i++)
    {
        if (n % i == 0)
        {
            result = true;
        }
    }
    return result;
}
```

## Tests

```csharp
bool test1 = IsNotPrime(2);
Debug.Assert(test1 == false);
```

```csharp
bool test2 = IsNotPrime(10);
Debug.Assert(test2 == true);
```

```csharp
bool test3 = IsNotPrime(35);
Debug.Assert(test3 == true);
```
