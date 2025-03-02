# mbcp-123 -- Sum amicable numbers up to a given limit

## Text

Write a function to sum all amicable numbers from 1 to a specified number.

## Code

```csharp
public static int AmicableNumbersSum(int limit)
{
    if (limit.GetType() != typeof(int))
    {
        return "Input is not an integer!";
    }
    if (limit < 1)
    {
        return "Input must be bigger than 0!";
    }
    HashSet<int> amicables = new HashSet<int>();
    for (int num = 2; num <= limit; num++)
    {
        if (amicables.Contains(num))
        {
            continue;
        }
        int sumFact = Enumerable.Range(1, num - 1).Where(fact => num % fact == 0).Sum();
        int sumFact2 = Enumerable.Range(1, sumFact - 1).Where(fact => sumFact % fact == 0).Sum();
        if (num == sumFact2 && num != sumFact)
        {
            amicables.Add(num);
            amicables.Add(sumFact2);
        }
    }
    return amicables.Sum();
}
```

## Test List

```csharp
Debug.Assert(AmicableNumbersSum(999) == 504);
```

```csharp
Debug.Assert(AmicableNumbersSum(9999) == 31626);
```

```csharp
Debug.Assert(AmicableNumbersSum(99) == 0);
```
