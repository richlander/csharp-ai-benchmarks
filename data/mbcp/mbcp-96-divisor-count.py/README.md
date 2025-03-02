# mbcp96 -- Count divisors of a given integer using Python

## Text

Write a C# function to find the number of divisors of a given integer.

## Code

```csharp
public int Divisor(int n)
{
    int x = 0;
    for (int i = 1; i <= n; i++)
    {
        if (n % i == 0)
        {
            x++;
        }
    }
    return x;
}
```

## Test List

```csharp
Debug.Assert(Divisor(15) == 4);
```

```csharp
Debug.Assert(Divisor(12) == 6);
```

```csharp
Debug.Assert(Divisor(9) == 3);
```
