# mbcp162 -- Sum positive integers in decreasing steps from n

## Text

Write a function to calculate the sum of the positive integers of n+(n-2)+(n-4)... (until n-x =< 0).

## Code

```csharp
public int SumSeries(int n) 
{
    if (n < 1) 
    {
        return 0;
    } 
    else 
    {
        return n + SumSeries(n - 2);
    }
}
```

## Test List

```csharp
Debug.Assert(SumSeries(6) == 12);
```

```csharp
Debug.Assert(SumSeries(10) == 30);
```

```csharp
Debug.Assert(SumSeries(9) == 25);
```
