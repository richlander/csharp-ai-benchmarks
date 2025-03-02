# mbcp-901 -- Find the smallest multiple of the first n numbers

## Text

Write a function to find the smallest multiple of the first n numbers.

## Code

```csharp
public static int SmallestMultiple(int n)
{
    if (n <= 2)
        return n;

    int i = n * 2;
    List<int> factors = new List<int>();

    for (int number = n; number > 1; number--)
    {
        if (number * 2 > n)
            factors.Add(number);
    }

    while (true)
    {
        foreach (int a in factors)
        {
            if (i % a != 0)
            {
                i += n;
                break;
            }
            if (a == factors[factors.Count - 1] && i % a == 0)
                return i;
        }
    }
}
```

## Test List

```csharp
Debug.Assert(SmallestMultiple(13) == 360360);
```

```csharp
Debug.Assert(SmallestMultiple(2) == 2);
```

```csharp
Debug.Assert(SmallestMultiple(1) == 1);
```
