# mbcp849 -- Sum of all prime divisors of a number in Python

## Text

Write a C# function to find sum of all prime divisors of a given number.

## Code

```csharp
public int Sum(int N) 
{
    int[] SumOfPrimeDivisors = new int[N + 1];
    for (int i = 2; i <= N; i++)
    {
        if (SumOfPrimeDivisors[i] == 0)
        {
            for (int j = i; j <= N; j += i)
            {
                SumOfPrimeDivisors[j] += i;
            }
        }
    }
    return SumOfPrimeDivisors[N];
}
```

## Test List

```csharp
Debug.Assert(Sum(60) == 10);
```

```csharp
Debug.Assert(Sum(39) == 16);
```

```csharp
Debug.Assert(Sum(40) == 7);
```
