# mbcp126 -- Sum of common divisors of two numbers in Python

## Text

Write a C# function to find the sum of common divisors of two given numbers.

## Code

```csharp
public int Sum(int a, int b) 
{
    int sum = 0;
    for (int i = 1; i < Math.Min(a, b); i++) 
    {
        if (a % i == 0 && b % i == 0) 
        {
            sum += i;
        }
    }
    return sum;
}
```

## Test List

```csharp
Debug.Assert(Sum(10, 15) == 6);
```

```csharp
Debug.Assert(Sum(100, 150) == 93);
```

```csharp
Debug.Assert(Sum(4, 6) == 3);
```
