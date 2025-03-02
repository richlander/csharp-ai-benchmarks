# mbcp704 -- Calculate the harmonic sum of n minus one

## Text

Write a function to calculate the harmonic sum of n-1.

## Code

```csharp
public double HarmonicSum(int n)
{
    if (n < 2)
        return 1;
    else
        return 1.0 / n + HarmonicSum(n - 1);
}
```

## Test List

```csharp
Debug.Assert(HarmonicSum(10) == 2.9289682539682538);

double HarmonicSum(int n) {
    double sum = 0.0;
    for (int i = 1; i <= n; i++) {
        sum += 1.0 / i;
    }
    return sum;
}
```

```csharp
Debug.Assert(HarmonicSum(4) == 2.083333333333333);
```

```csharp
Debug.Assert(HarmonicSum(7) == 2.5928571428571425);
```
