# mbcp486 -- Compute binomial probability for a given number

## Text

Write a function to compute binomial probability for the given number.

## Code

```csharp
int NCr(int n, int r) 
{
    if (r > n / 2) 
    {
        r = n - r;
    }
    int answer = 1;
    for (int i = 1; i <= r; i++) 
    {
        answer *= (n - r + i);
        answer /= i;
    }
    return answer;
}

double BinomialProbability(int n, int k, double p) 
{
    return (NCr(n, k) * Math.Pow(p, k) * Math.Pow(1 - p, n - k));
}
```

## Test List

```csharp
Debug.Assert(BinomialProbability(10, 5, 1.0 / 3) == 0.13656454808718185);
```

```csharp
Debug.Assert(BinomialProbability(11, 6, 2.0 / 4) == 0.2255859375);
```

```csharp
Debug.Assert(BinomialProbability(12, 7, 3.0 / 5) == 0.227030335488);
```
