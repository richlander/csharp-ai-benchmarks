# mbcp295 -- Sum all divisors of a given number in a function

## Text

Write a function to return the sum of all divisors of a number.

## Code

```csharp
public int SumDiv(int number)
{
    List<int> divisors = new List<int> { 1 };
    for (int i = 2; i < number; i++)
    {
        if (number % i == 0)
        {
            divisors.Add(i);
        }
    }
    return divisors.Sum();
}
```

## Test List

```csharp
Debug.Assert(SumDiv(8) == 7);
```

```csharp
Debug.Assert(SumDiv(12) == 16);
```

```csharp
Debug.Assert(SumDiv(7) == 1);
```
